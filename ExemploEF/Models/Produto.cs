namespace ExemploEF.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;

        public decimal Preco { get; set; }

        public Guid CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }
    }
}
