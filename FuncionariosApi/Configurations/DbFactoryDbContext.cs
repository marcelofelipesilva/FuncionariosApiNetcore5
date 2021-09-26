using FuncionariosApi.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FuncionariosApi.Configurations
{
    public class DbFactoryDbContext :  IDesignTimeDbContextFactory<FuncionariosApiDbContext>
    {
        public FuncionariosApiDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FuncionariosApiDbContext>();
            FuncionariosApiDbContext contexto = new FuncionariosApiDbContext(optionsBuilder.Options);
            return contexto;
        }
    }
}