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
    public partial class FormCadastroC : System.Windows.Forms.Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string csvClientes = "C:/Users/thiag/Documents/csvLogin.txt";
        private int indiceEdicao = -1;

        public FormCadastroC()
        {
            InitializeComponent();
            InicializarCsvSeNecessario();
        }

        private void FormCadastroC_Load(object sender, EventArgs e)
        {

        }
        private void InicializarCsvSeNecessario()
        {
            if (!File.Exists(csvClientes))
            {
                using (StreamWriter sw = new StreamWriter(csvClientes))
                {
                    sw.WriteLine("Nome,CPF,Email,CEP,Logradouro,Número,Bairro,Cidade,Estado,Telefone,Whatsapp)");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text.Trim();
            string cpf = mtbCPF.Text.Trim();
            string telefone = mtbTelefone.Text.Trim();
            string endereco = txbEndereco.Text.Trim();

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
                }ghdfg

                dgvDados.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task GetExampleAsync()
        {
            try
            {
                string url = "https://jsonplaceholder.typicode.com/posts/1";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                MessageBox.Show("GET Response:\n" + responseBody);
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Erro na requisição GET: " + e.Message);
            }
        }

        private async void textBox6_TextChanged(object sender, EventArgs e)
        {
            await GetExampleAsync();
        }
    }
}
