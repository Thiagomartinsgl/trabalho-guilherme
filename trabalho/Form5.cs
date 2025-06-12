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
    public partial class FormCadastroP : System.Windows.Forms.Form
    {
        private string caminhoArquivo = "C:/Users/thiag/Documents/csvProdutos";
        private int indiceEdicao = -1;

        public FormCadastroP()
        {
            InitializeComponent();
            InicializarArquivo();
            CarregarCsvNoGrid();
        }

        private void FormCadastroP_Load(object sender, EventArgs e)
        {

        }
        private void InicializarArquivo()
        {
            if (!File.Exists(caminhoArquivo))
            {
                File.WriteAllText(caminhoArquivo, "Nome,Preco,Descricao");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txbProduto.Text.Trim();
            string preco = txbPreco.Text.Trim();
            string descricao = txbDes.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(preco))
            {
                MessageBox.Show("Preencha o nome e o preço do produto.");
                return;
            }

            var linhas = File.ReadAllLines(caminhoArquivo).ToList();

            if (indiceEdicao == -1)
            {
                linhas.Add($"{nome},{preco},{descricao}");
            }
            else
            {
                linhas[indiceEdicao + 1] = $"{nome},{preco},{descricao}";
                indiceEdicao = -1;
                btnCadastrar.Text = "Cadastrar";
            }

            File.WriteAllLines(caminhoArquivo, linhas);
            MessageBox.Show("Produto salvo com sucesso!");

            txbProduto.Clear();
            txbPreco.Clear();
            txbDes.Clear();

            CarregarCsvNoGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para editar.");
                return;
            }

            int linhaSelecionada = dgvProdutos.SelectedRows[0].Index;
            DataGridViewRow linha = dgvProdutos.Rows[linhaSelecionada];

            txbProduto.Text = linha.Cells[0].Value.ToString();
            txbPreco.Text = linha.Cells[1].Value.ToString();
            txbDes.Text = linha.Cells[2].Value.ToString();

            indiceEdicao = linhaSelecionada;
            btnCadastrar.Text = "Salvar";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }

            int linhaSelecionada = dgvProdutos.SelectedRows[0].Index;
            var linhas = File.ReadAllLines(caminhoArquivo).ToList();

            linhas.RemoveAt(linhaSelecionada + 1);
            File.WriteAllLines(caminhoArquivo, linhas);

            CarregarCsvNoGrid();
            MessageBox.Show("Produto excluído com sucesso!");
        }
        private void CarregarCsvNoGrid()
        {
            try
            {
                DataTable tabela = new DataTable();
                string[] linhas = File.ReadAllLines(caminhoArquivo);

                if (linhas.Length > 0)
                {
                    string[] colunas = linhas[0].Split(',');

                    foreach (string coluna in colunas)
                        tabela.Columns.Add(coluna);

                    for (int i = 1; i < linhas.Length; i++)
                    {
                        string[] dados = linhas[i].Split(',');
                        tabela.Rows.Add(dados);
                    }
                }

                dgvProdutos.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }
    }
}
