using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FuncionariosApi.Business.Entities
{
    public class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FuncionarioID { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        [StringLength(25)]
        public int Matricula { get; set; }
        [StringLength(8)]
        public string Senha { get; set; }
        [StringLength(20)]
        public string DataAdmissao { get; set; }
        [StringLength(40)]
        public string Cargo { get; set; }
        [StringLength(100)]
        public string DetalhesFuncao { get; set; }
    }
}