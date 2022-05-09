using AutoMapper;
using NotasWorkshop.Bl.Dtos;
using NotasWorkshop.Bl.Extensions;
using NotasWorkshop.Model.Entities;

namespace NotasWorkshop.Bl.Mappings
{
    public class NoteProfile : Profile
    {
        public NoteProfile()
        {
            this._CreateMap_WithConventions_FromAssemblies<Note, NoteDto>();

            /// CreateMap<Note, NoteDto>().ReverseMap();
            /// CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
