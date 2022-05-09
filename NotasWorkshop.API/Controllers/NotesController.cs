using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using NotasWorkshop.Api.Controllers;
using NotasWorkshop.Bl.Dtos;
using NotasWorkshop.Model.Entities;
using NotasWorkshop.Services.Services;

namespace NotasWorkshop.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : BaseController<Note, NoteDto>
    {
        public NotesController(INoteService noteService,
            IValidatorFactory validationFactory,
            IMapper mapper) 
            : base(noteService, validationFactory, mapper)
        {
        }
    }
}
