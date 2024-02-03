using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using static Controle_de_Estoque_CSharp.ControleEstoque;

namespace Controle_de_Estoque_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool verificarCampos()
        {

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Nome.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtValorCompra.Text, out decimal valorCompra) || valorCompra < 0)
            {
                MessageBox.Show("Por favor, insira um valor de compra válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtValorVenda.Text, out decimal valorVenda) || valorVenda < 0)
            {
                MessageBox.Show("Por favor, insira um valor de venda válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade < 0)
            {
                MessageBox.Show("Por favor, insira uma quantidade válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                using var db = new ControleEstoque();
                db.Add(new Produto { Nome = txtNome.Text, ValorCompra = Convert.ToDecimal(txtValorCompra.Text), ValorVenda = Convert.ToDecimal(txtValorVenda.Text), Quantidade = Convert.ToInt32(txtQuantidade.Text) });
                db.SaveChanges();
                MessageBox.Show("Produto inserido com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                produtoBindingSource.DataSource = db.Produtos.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new ControleEstoque())
            {
                produtoBindingSource.DataSource = db.Produtos.ToList();
            }
        }

        private void bntDeletar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                var produto = produtoBindingSource.Current as Produto;

                if (produto != null)
                {
                    using (var db = new ControleEstoque())
                    {
                        db.Entry(produto).State = EntityState.Deleted;
                        db.SaveChanges();

                        MessageBox.Show($"Produto {produto.Nome} excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        produtoBindingSource.DataSource = db.Produtos.ToList();
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new ControleEstoque())
            {
                var texto = produtoBindingSource.Current as Produto;
                lbTeste.Text = $"Produto ID: {texto.ProdutoId}";
                produtoBindingSource.DataSource = db.Produtos.ToList();
                txtNome.Text = texto.Nome;
                txtValorCompra.Text = texto.ValorCompra.ToString();
                txtValorVenda.Text = texto.ValorVenda.ToString();
                txtQuantidade.Text = texto.Quantidade.ToString();
                produtoBindingSource.DataSource = db.Produtos.ToList();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                using (var db = new ControleEstoque())
                {
                    var produtoSelecionado = produtoBindingSource.Current as Produto;

                    if (produtoSelecionado != null)
                    {
                        produtoSelecionado.Nome = txtNome.Text;
                        produtoSelecionado.ValorCompra = Convert.ToDecimal(txtValorCompra.Text);
                        produtoSelecionado.ValorVenda = Convert.ToDecimal(txtValorVenda.Text);
                        produtoSelecionado.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                        db.Entry(produtoSelecionado).State = EntityState.Modified;

                        db.SaveChanges();

                        MessageBox.Show($"Produto {produtoSelecionado.Nome} atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        produtoBindingSource.DataSource = db.Produtos.ToList();
                    }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtValorCompra.Text = "";
            txtValorVenda.Text = "";
            txtQuantidade.Text = "";
            lbTeste.Text = "";
        }
    }
}