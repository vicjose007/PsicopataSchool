using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotasWorkshop.Model.Entities;
using NotasWorkshop.Model.Repositories;

namespace NotasWorkshop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ITokenService _TokenService;

        public LoginController(ITokenService tokenService)
        {
            _TokenService = tokenService;

        }
    [HttpPost]
    [Route("authenticate")]
    public IActionResult Authenticate(User user)
    {
        var token = _TokenService.Authenticate(user);

        if (token == null)
        {
            return Unauthorized();
        }

        return Ok(token);
    }
    }


}
