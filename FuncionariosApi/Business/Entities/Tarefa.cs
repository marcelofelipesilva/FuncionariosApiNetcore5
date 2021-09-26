using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic.CompilerServices;

namespace FuncionariosApi.Business.Entities
{
    public class Tarefa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TarefaID { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        
        public string DataEntrega { get; set; }
        [StringLength(150)]
        public string DescricaoTarefa { get; set; }
        [StringLength(15)]
        public string Status { get; set; }
    }
}