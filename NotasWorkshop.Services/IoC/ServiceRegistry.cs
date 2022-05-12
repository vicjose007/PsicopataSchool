using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NotasWorkshop.Model.Repositories;
using NotasWorkshop.Services.Services;

namespace NotasWorkshop.Services.IoC
{
    public static class ServiceRegistry
    {
        public static void AddServicesRegistry(this IServiceCollection services)
        {
            services.AddScoped<INoteService, NoteService>();
            services.AddScoped<ITokenService, TokenService>();

        }
    }
}
