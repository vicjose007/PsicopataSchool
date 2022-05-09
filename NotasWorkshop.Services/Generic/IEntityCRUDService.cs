using NotasWorkshop.Core.BaseModel.BaseEntity;
using NotasWorkshop.Core.BaseModel.BaseEntityDto;

namespace NotasWorkshop.Services.Generic
{
    public interface IEntityCRUDService<TEntity, TEntityDto> where TEntity : class, IBaseEntity
       where TEntityDto : class, IBaseEntityDto
    {
        Task<TEntityDto> GetById(int id);
        Task<TEntityDto> Save(TEntityDto entityDto);
        Task<TEntityDto> Update(int id, TEntityDto entityDto);
        Task<TEntityDto> Delete(int id);
        IQueryable<TEntity> Get();
    }
}
