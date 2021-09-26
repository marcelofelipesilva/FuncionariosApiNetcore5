namespace FuncionariosApi.Models
{
    public class FuncionarioViewModelOutput
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string Senha { get; set; }
        public string DataAdmissao { get; set; }
        public string Cargo { get; set; }
        public string DetalhesFuncao { get; set; }
    }
}