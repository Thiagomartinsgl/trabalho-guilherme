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
    public partial class FormConsultaPedidos : System.Windows.Forms.Form
    {
        private string csvClientes = "C:/Users/thiag/Documents/csvClientes";
        private string csvPedidos = "C:/Users/thiag/Documents/csvPedidos";

        public FormConsultaPedidos()
        {
            InitializeComponent();//85
        }

        private void FormConsultaPedidos_Load(object sender, EventArgs e)
        {
            ltvPedidos.View = View.Details;
            ltvPedidos.Columns.Add("Descrição", 150);
            ltvPedidos.Columns.Add("Total do Pedido", 100);
            ltvPedidos.Columns.Add("Itens do Pedido", 0);
            ltvItens.View = View.Details;
            ltvItens.Columns.Add("Detalhes do Item", 250);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = txbCPF.Text.Trim();
            if (string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show("Digite o CPF para consultar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomeCliente = "Desconhecido";
            if (File.Exists(csvClientes))
            {
                string[] linhasClientes = File.ReadAllLines(csvClientes);
                foreach (var linha in linhasClientes.Skip(1))
                {
                    var dados = linha.Split(',');
                    if (dados.Length >= 2 && dados[1] == cpf)
                    {
                        nomeCliente = dados[0];
                        break;
                    }
                }
            }
            lblNome.Text = $"Cliente: {nomeCliente}";

            ltvPedidos.Items.Clear();
            ltvItens.Items.Clear();

            if (!File.Exists(csvPedidos))
            {
                MessageBox.Show("Arquivo de pedidos não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] linhasPedidos = File.ReadAllLines(csvPedidos);
            foreach (var linha in linhasPedidos.Skip(1))
            {
                string[] partes;
                partes = linha.Split(',');

                if (partes.Length >= 4 && partes[1] == cpf)
                {
                    ListViewItem item = new ListViewItem(partes[0]);
                    item.SubItems.Add(partes[3]);
                    string itensLimpos = partes[2].Trim('"');
                    item.SubItems.Add(itensLimpos);
                    ltvPedidos.Items.Add(item);
                }
            }
            if (ltvPedidos.Items.Count == 0)
            {
                MessageBox.Show("Nenhum pedido encontrado para este CPF.", "Consulta de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ltvPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltvPedidos.SelectedItems.Count == 0) return;

            ltvItens.Items.Clear();

            var itemSelecionado = ltvPedidos.SelectedItems[0];
            string produtosString = itemSelecionado.SubItems[2].Text;
            string[] produtos = produtosString.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var p in produtos)
            {
                if (!string.IsNullOrWhiteSpace(p))
                {
                    ltvItens.Items.Add(p.Trim());
                }
            }
        }
    }
}
