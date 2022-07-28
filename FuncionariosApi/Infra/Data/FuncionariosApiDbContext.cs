using FuncionariosApi.Business.Entities;
using FuncionariosApi.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace FuncionariosApi.Infra.Data
{
    public class FuncionariosApiDbContext : DbContext
    {
        public FuncionariosApiDbContext(DbContextOptions<FuncionariosApiDbContext> options) : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioMapping());
            modelBuilder.ApplyConfiguration(new TarefaMapping());
           
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=funcionariosbd;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}