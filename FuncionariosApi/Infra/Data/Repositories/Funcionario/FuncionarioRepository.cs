using System.Collections.Generic;
using System.Linq;
using FuncionariosApi.Business.Entities;
using FuncionariosApi.Business.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace FuncionariosApi.Infra.Data.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly FuncionariosApiDbContext _context;

        public FuncionarioRepository(FuncionariosApiDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Funcionario funcionario)
        {
            _context.Add(funcionario);

        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public List<Funcionario> obterlivros(int FuncionarioID)
        {
            return _context.Funcionarios.Include(i => i.FuncionarioID).Where(w => w.FuncionarioID == FuncionarioID).ToList();
        }
    }
}