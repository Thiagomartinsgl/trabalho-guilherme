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
        private string csvClientes = "C:/Users/thiag/Documents/csvClientes";
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
                    sw.WriteLine("Nome,CPF,Email,CEP,Logradouro,Número,Bairro,Cidade,Estado,Telefone,Whatsapp");
                }
            }
        }

        private void CarregarCsvNoGrid()
        {
            try
            {
                DataTable tabela = new DataTable();
                string[] linhas = File.ReadAllLines(csvClientes);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task GetExampleAsync()
        {
            string cep = txbCEP.Text.Trim().Replace("-", "").Replace(".", "");

            if (cep.Length != 8)
            {
                MessageBox.Show("CEP inválido.");
                return;
            }

            try
            {
                string url = $"https://viacep.com.br/ws/{cep}/json/";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                //MessageBox.Show(responseBody);

                string elogradouro = ExtrairValor(responseBody, "\"logradouro\": \"", "\"");
                string ebairro = ExtrairValor(responseBody, "\"bairro\": \"", "\"");
                string ecidade = ExtrairValor(responseBody, "\"localidade\": \"", "\"");
                string eestado = ExtrairValor(responseBody, "\"uf\": \"", "\"");

                txbLogradouro.Text = elogradouro;
                txbBairro.Text = ebairro;
                txbCidade.Text = ecidade;
                txbEstado.Text = eestado;
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Erro na requisição GET: " + e.Message);
            }
        }
        private string ExtrairValor(string texto, string chaveInicio, string chaveFim)
        {
            int indiceInicio = texto.IndexOf(chaveInicio);
            if (indiceInicio == -1) return "";

            indiceInicio += chaveInicio.Length;

            int indiceFim = texto.IndexOf(chaveFim, indiceInicio);
            if (indiceFim == -1) return "";

            return texto.Substring(indiceInicio, indiceFim - indiceInicio);
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await GetExampleAsync();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text.Trim();
            string cpf = txbCPF.Text.Trim();
            string telefone = txbTelefone.Text.Trim();
            string endereco = txbLogradouro.Text.Trim();
            string Email = txbEmail.Text.Trim();
            string CEP = txbCEP.Text.Trim();
            string Numero = txbNumero.Text.Trim();
            string Bairro = txbBairro.Text.Trim();
            string Cidade = txbCidade.Text.Trim();
            string Estado = txbEstado.Text.Trim();
            string Whatsapp = txbWhatsapp.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(endereco) ||
                string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(CEP) || string.IsNullOrWhiteSpace(Numero) || string.IsNullOrWhiteSpace(Bairro) ||
                string.IsNullOrWhiteSpace(Cidade) || string.IsNullOrWhiteSpace(Estado) || string.IsNullOrWhiteSpace(Whatsapp))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var linhas = File.ReadAllLines(csvClientes).ToList();

            if (indiceEdicao == -1)
            {
                if (linhas.Skip(1).Any(l =>
                {
                    string[] partes = l.Split(',');
                    return partes.Length > 1 && partes[1] == cpf;
                }))
                {
                    MessageBox.Show("Este CPF já está cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                linhas.Add($"{nome},{cpf},{telefone},{endereco},{Email},{CEP},{Numero},{Bairro},{Cidade},{Estado},{Whatsapp}");
            }
            else
            {
                linhas[indiceEdicao + 1] = $"{nome},{cpf},{telefone},{endereco},{Email},{CEP},{Numero},{Bairro},{Cidade},{Estado},{Whatsapp}";
                indiceEdicao = -1;
                btnSalvar.Text = "Salvar";
            }

            File.WriteAllLines(csvClientes, linhas);
            MessageBox.Show("Dados salvos com sucesso!");

            txbNome.Clear();
            txbCPF.Clear();
            txbTelefone.Clear();
            txbLogradouro.Clear();
            txbEmail.Clear();
            txbCEP.Clear();
            txbNumero.Clear();
            txbBairro.Clear();
            txbCidade.Clear();
            txbEstado.Clear();
            txbWhatsapp.Clear();

            CarregarCsvNoGrid();
        }
    }
}
