namespace TesteAecEnderecos.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public int UsuarioId { get; set; }
    }
}