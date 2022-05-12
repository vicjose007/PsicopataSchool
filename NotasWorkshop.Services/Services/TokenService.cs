using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NotasWorkshop.Model.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NotasWorkshop.Model.Repositories
{
    public interface ITokenService
    {
        Tokens Authenticate(User user);
    }
    public class TokenService : ITokenService
    {

        Dictionary<string, string> UsersRecords = new Dictionary<string, string>
    {
        { "admin","admin"},
        { "password","password"}
    };

        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Tokens Authenticate(User user)
        {
            if (!UsersRecords.Any(x => x.Key == user.Name && x.Value == user.Password))
            {
                return null;
            }

            //Generate JSON Web Token
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(_configuration["JWT:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
              {
             new Claim(ClaimTypes.Name, user.Name)
              }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return new Tokens { Token = tokenHandler.WriteToken(token) };
        }
    }
}
