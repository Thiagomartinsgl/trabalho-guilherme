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
    public partial class FormCadastroU : System.Windows.Forms.Form
    {
        private string csvUsuario = "C:/Users/thiag/Documents/csvLogin.txt";
        private int indiceEdicao = -1;

        public FormCadastroU()
        {
            InitializeComponent();
            InicializarCsvSeNecessario();
        }

        private void FormCadastroU_Load(object sender, EventArgs e)
        {

        }
        private void InicializarCsvSeNecessario()
        {
            if (!File.Exists(csvUsuario))
            {
                using (StreamWriter sw = new StreamWriter(csvUsuario))
                {
                    sw.WriteLine("Usuario,Senha");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text.Trim();
            string cpf = mtbCPF.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(endereco))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var linhas = File.ReadAllLines(caminhoCsv).ToList();

            if (indiceEdicao == -1)
            {
                if (linhas.Skip(1).Any(l => l.Split(',')[1] == cpf))
                {
                    MessageBox.Show("Este CPF já está cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                linhas.Add($"{nome},{cpf},{telefone},{endereco}");
            }
            else
            {
                linhas[indiceEdicao + 1] = $"{nome},{cpf},{telefone},{endereco}";
                indiceEdicao = -1;
                btnSalvar.Text = "Salvar";
            }

            File.WriteAllLines(caminhoCsv, linhas);
            MessageBox.Show("Dados salvos com sucesso!");

            txbNome.Clear();
            mtbCPF.Clear();
            mtbTelefone.Clear();
            txbEndereco.Clear();

            CarregarCsvNoGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvDados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para excluir.");
                return;
            }

            int rowIndex = dgvDados.SelectedRows[0].Index;
            var linhas = File.ReadAllLines(caminhoCsv).ToList();
            linhas.RemoveAt(rowIndex + 1);
            File.WriteAllLines(caminhoCsv, linhas);
            CarregarCsvNoGrid();
        }
        private void CarregarCsvNoGrid()
        {
            try
            {
                DataTable tabela = new DataTable();
                string[] linhas = File.ReadAllLines(caminhoCsv);

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

                dgvDados.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
