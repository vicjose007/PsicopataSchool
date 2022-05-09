using AutoMapper;
using NotasWorkshop.Bl.Dtos;
using NotasWorkshop.Model.Contexts.NotasWorkshop;
using NotasWorkshop.Model.Entities;
using NotasWorkshop.Model.UnitOfWorks;
using NotasWorkshop.Services.Generic;

namespace NotasWorkshop.Services.Services
{
    public interface INoteService : IEntityCRUDService<Note, NoteDto>
    {
        // Agregar mas metodo al servicio
    }

    public class NoteService : EntityCRUDService<Note, NoteDto>, INoteService
    {
        public NoteService(IMapper mapper, IUnitOfWork<INotasWorkshopDbContext> uow) 
            : base(mapper, uow)
        {
        }
    }
}
