using System.Collections.Generic;
using System.Linq;
using FuncionariosApi.Business.Entities;
using FuncionariosApi.Business.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace FuncionariosApi.Infra.Data.Repositories
{
    public class TarefaRepository : ITarefaRepsository
    {
        private readonly FuncionariosApiDbContext _context;

        public TarefaRepository(FuncionariosApiDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Tarefa tarefa)
        {
            _context.Add(tarefa);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public List<Tarefa> obterlivros(int TarefaID)
        {
            return _context.Tarefas.Include(i => i.TarefaID).Where(w => w.TarefaID == TarefaID).ToList();
        }
    }
}