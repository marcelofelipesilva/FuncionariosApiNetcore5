using System.Linq;
using FuncionariosApi.Infra.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FuncionariosApi.Configurations
{
    public static class EntityFrameworkExtensions {
      
        public static IApplicationBuilder UseApplyMigration(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var FuncionariosApiDbContext = serviceScope.ServiceProvider.GetService<FuncionariosApiDbContext>())
                {
                    var migracoesPendentes = FuncionariosApiDbContext.Database.GetPendingMigrations();

                    if (migracoesPendentes.Count() == 0)
                    {
                        return app;
                    }

                    FuncionariosApiDbContext.Database.Migrate();
                }
            }

            return app;
        }
    }
}