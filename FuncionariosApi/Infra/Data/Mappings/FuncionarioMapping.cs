using FuncionariosApi.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuncionariosApi.Infra.Data.Mappings
{
    public class FuncionarioMapping : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("TB_Funcionario");
            builder.HasKey(p => p.FuncionarioID);
            builder.Property(p => p.FuncionarioID).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome);
            builder.Property(p => p.Matricula);
            builder.Property(p => p.Senha);
            builder.Property(p => p.DataAdmissao);
            builder.Property(p => p.DetalhesFuncao);
        }
    }
}