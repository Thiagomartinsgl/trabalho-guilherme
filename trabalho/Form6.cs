using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho
{
    public partial class FormCadastroPedidos : System.Windows.Forms.Form
    {
        decimal totalPedido = 0;

        public FormCadastroPedidos()
        {
            InitializeComponent();
        }

        private void FormCadastroPedidos_Load(object sender, EventArgs e)
        {
            string caminhoProdutos = "C:/Users/thiag/Documents/csvProdutos";

            if (File.Exists(caminhoProdutos))
            {
                string[] linhas = File.ReadAllLines(caminhoProdutos);

                foreach (string linha in linhas.Skip(1))
                {
                    string[] partes = linha.Split(',');
                    if (partes.Length >= 1)
                    {
                        cbxProduto.Items.Add(partes[0]);
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = cbxProduto.Text;
            decimal preco = Convert.ToDecimal(txbValor.Text);
            int quantidade = Convert.ToInt32(txbQuantidade.Text);

            decimal totalItem = preco * quantidade;

            totalPedido += totalItem;
            txbTotal.Text = "Total: R$" + totalPedido.ToString("F2");

            string nome1 = cbxProduto.SelectedItem.ToString();
            string quantidade1 = txbQuantidade.Text;
            string preco1 = txbValor.Text;
            decimal totalItem1 = Convert.ToDecimal(preco) * Convert.ToInt32(quantidade);

            lbProdutos.Items.Add($"{nome} - {quantidade} - {preco} - {totalItem}");

            txbQuantidade.Clear();
        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string produtoSelecionado = cbxProduto.SelectedItem.ToString();
            string caminhoProdutos = "C:/Users/thiag/Documents/csvProdutos";

            string[] linhas = File.ReadAllLines(caminhoProdutos);

            foreach (string linha in linhas.Skip(1))
            {
                string[] partes = linha.Split(',');
                if (partes.Length >= 2 && partes[0] == produtoSelecionado)
                {
                    txbValor.Text = partes[1];
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buscaCPF = txbCPF.Text.Trim();
            string csvClientes = "C:/Users/thiag/Documents/csvClientes";

            if (!File.Exists(csvClientes))
            {
                MessageBox.Show("Arquivo de clientes não encontrado.");
                return;
            }

            string[] linhas = File.ReadAllLines(csvClientes);

            foreach (string linha in linhas.Skip(1))
            {
                string[] partes = linha.Split(',');
                if (partes.Length >= 2 && partes[1] == buscaCPF)
                {
                    txbNome.Text = partes[0];
                    return;
                }
            }

            MessageBox.Show("Cliente não encontrado.");
            txbNome.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lbProdutos.SelectedIndex != -1)
            {
                lbProdutos.Items.RemoveAt(lbProdutos.SelectedIndex);
                AtualizarTotalPedido();
            }
            else
            {
                MessageBox.Show("Selecione um item para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void AtualizarTotalPedido()
        {
            decimal total = 0;

            foreach (var item in lbProdutos.Items)
            {
                string linha = item.ToString();
                string[] partes = linha.Split('-');

                if (partes.Length == 4)
                {
                    bool qtdValida = int.TryParse(partes[1].Trim(), out int qtd);
                    bool precoValido = decimal.TryParse(partes[2].Trim(), out decimal preco);

                    if (qtdValida && precoValido)
                    {
                        total += qtd * preco;
                    }
                }
            }

            txbTotal.Text = $"Total: R${total:0.00}";
        }
    }fdsg
}
