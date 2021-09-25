using System.Collections.Generic;
using FuncionariosApi.Business.Entities;

namespace FuncionariosApi.Business.IRepositories
{
    public interface ITarefaRepsository
    {
        void Adicionar(Tarefa tarefa);
        void Commit();

        List<Tarefa> obterlivros(int TarefaID);
    }
}