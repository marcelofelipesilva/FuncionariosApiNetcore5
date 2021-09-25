using System.Collections.Generic;
using FuncionariosApi.Business.Entities;

namespace FuncionariosApi.Business.IRepositories
{
    public interface IFuncionarioRepository
    {
        void Adicionar(Funcionario funcionario);
        void Commit();

        List<Funcionario> obterlivros(int FuncionarioID);
    }
}