using Microsoft.Extensions.DependencyInjection;
using NotasWorkshop.Model.Contexts.NotasWorkshop;
using NotasWorkshop.Model.UnitOfWorks;
using NotasWorkshop.Model.UnitOfWorks.NotasWorkshop;

namespace NotasWorkshop.Model.IoC
{
    public static class ModelRegistry
    {
        public static void AddModelRegistry(this IServiceCollection services)
        {
            services.AddTransient<INotasWorkshopDbContext, NotasWorkshopDbContext>();
            services.AddScoped<IUnitOfWork<INotasWorkshopDbContext>, NotasWorkshopUnitOfWork>();
        }
    }
}
