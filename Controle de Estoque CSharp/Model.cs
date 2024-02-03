using Microsoft.EntityFrameworkCore;

namespace Controle_de_Estoque_CSharp
{
    public class ControleEstoque : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public string DbPath { get; }

        public ControleEstoque()
        {
            DbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dbEstoque.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenda { get; set; }
        public int Quantidade { get; set; }
        public override string ToString()
        {
            return $"ID: {ProdutoId}, Nome: {Nome}, Valor Compra: {ValorCompra:C}, Valor Venda: {ValorVenda:C}, Quantidade: {Quantidade}";
        }
    }
}