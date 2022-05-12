using NotasWorkshop.Core.BaseModel.BaseEntity;
using NotasWorkshop.Model.Contexts.NotasWorkshop;
using NotasWorkshop.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NotasWorkshop.Model.UnitOfWorks.NotasWorkshop
{
    public class NotasWorkshopUnitOfWork : IUnitOfWork<INotasWorkshopDbContext>
    {
        public INotasWorkshopDbContext context { get; set; }
        public readonly IServiceProvider _serviceProvider;

        public NotasWorkshopUnitOfWork(IServiceProvider serviceProvider, INotasWorkshopDbContext context)
        {
            _serviceProvider = serviceProvider;
            this.context = context;
        }

        public async Task<int> Commit()
        {
            var result = await context.SaveChangesAsync();
            return result;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IBaseEntity
        {
            return (_serviceProvider.GetService(typeof(TEntity)) ?? new BaseRepository<TEntity>(this)) as IRepository<TEntity>;
        }
    }
}
