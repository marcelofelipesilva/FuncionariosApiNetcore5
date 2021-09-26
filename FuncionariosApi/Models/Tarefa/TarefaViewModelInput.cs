using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

namespace FuncionariosApi.Models.Tarefa
{
    public class TarefaViewModelInput
    {
        [Required(ErrorMessage = "o Campo Nome é obrigatório. ")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "o Campo Data da Entrega é obrigatório. ")]
        public string DataEntrega { get; set; }
        [Required(ErrorMessage = "o Campo Descrição da Tarefa é obrigatório. ")]
        public string DescricaoTarefa { get; set; }
        [Required(ErrorMessage = "o Campo Status é obrigatório. ")]
        public string Status { get; set; }
    }
}