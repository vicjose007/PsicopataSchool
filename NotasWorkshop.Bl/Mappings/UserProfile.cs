using AutoMapper;
using NotasWorkshop.Bl.Dtos;
using NotasWorkshop.Bl.Extensions;
using NotasWorkshop.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasWorkshop.Bl.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            this._CreateMap_WithConventions_FromAssemblies<User, UserDto>();
        }
   
    }
}
