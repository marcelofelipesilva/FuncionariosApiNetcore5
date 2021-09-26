using Microsoft.VisualBasic.CompilerServices;

namespace FuncionariosApi.Models.Tarefa
{
    public class TarefaViewModelOutput
    {
        public string Nome { get; set; }
        public DateType DataEntrega { get; set; }
        public string DescricaoTarefa { get; set; }
        public string Status { get; set; }
    }
}