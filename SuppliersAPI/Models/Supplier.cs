namespace SuppliersAPI.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string CPF_CNPJ { get; set; }
    }
}