using FuncionariosApi.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuncionariosApi.Infra.Data.Mappings
{
    public class TarefaMapping : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("TB_Tarefa");
            builder.HasKey(p => p.TarefaID);
            builder.Property(p => p.TarefaID).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome);
            builder.Property(p => p.DataEntrega);
            builder.Property(p => p.Status);
           
        }
    }
}