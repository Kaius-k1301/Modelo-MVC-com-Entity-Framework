namespace ExemploEF.Models
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }

        public string Nome { get; set; } = string.Empty;

        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
