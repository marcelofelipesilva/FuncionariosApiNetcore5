using System.ComponentModel.DataAnnotations;

namespace FuncionariosApi.Models
{
    public class FuncionarioViewModelInput
    {
        [Required(ErrorMessage = "O Campo Nome é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Campo Matricula é obrigatório.")]
        public int Matricula { get; set; }
        [Required(ErrorMessage = "O Campo Senha é obrigatório.")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "O Campo Data de Admissao é obrigatório.")]
        public string DataAdmissao { get; set; }
        [Required(ErrorMessage = "O Campo Cargo é obrigatório.")]
        public string Cargo { get; set; }
        [Required(ErrorMessage = "O Campo Detalhes da Funcao é obrigatório.")]
        public string DetalhesFuncao { get; set; }
    }
}