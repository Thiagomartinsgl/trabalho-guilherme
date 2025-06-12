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
        private string csvUsuario = "C:/Users/thiag/Documents/csvLogin";
        private int indiceEdicao = -1;
        private string usuarioLogado;

        public FormCadastroU(string usuario)
        {
            InitializeComponent();
            InicializarCsvSeNecessario();
            usuarioLogado = usuario;FDSGBVDF
        }

        private void FormCadastroU_Load(object sender, EventArgs e)
        {
            if (usuarioLogado != "ADMIN")
            {
                dgvUsuario.Visible = true;
                label1.Visible = true;
                btnSalvar.Visible = true;
                lblUsuario.Visible = false;
                lblSenha.Visible = false;
                txbUsuario.Visible = false;
                txbSenha.Visible = false;
                btnCadastrar.Visible = false;
                btnExcluir.Visible = false;
            }
            else
            {
                lblUsuario.Visible = true;
                lblSenha.Visible = true;
                txbUsuario.Visible = true;
                txbSenha.Visible = true;
                btnCadastrar.Visible = true;
                btnExcluir.Visible = true;
                dgvUsuario.Visible = true;
                label1.Visible = false;
                btnSalvar.Visible = false;
            }

            CarregarCsvNoGrid();
            dgvUsuario.Columns[0].ReadOnly = true;
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para excluir.");
                return;
            }

            int rowIndex = dgvUsuario.SelectedRows[0].Index;
            var linhas = File.ReadAllLines(csvUsuario).ToList();
            linhas.RemoveAt(rowIndex + 1);
            File.WriteAllLines(csvUsuario, linhas);
            CarregarCsvNoGrid();
        }
        private void CarregarCsvNoGrid()
        {
            try
            {
                DataTable tabela = new DataTable();
                string[] linhas = File.ReadAllLines(csvUsuario);

                if (linhas.Length > 0)
                {
                    string[] colunas = linhas[0].Split(',');

                    foreach (string coluna in colunas)
                        tabela.Columns.Add(coluna);

                    for (int i = 1; i < linhas.Length; i++)
                    {
                        string[] dados = linhas[i].Split(',');

                        if (usuarioLogado == "ADMIN" || dados[0] == usuarioLogado)
                        {
                            tabela.Rows.Add(dados);
                        }
                    }
                }

                dgvUsuario.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txbUsuario.Text.Trim();
            string senha = txbSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var linhas = File.ReadAllLines(csvUsuario).ToList();

            if (indiceEdicao == -1)
            {
                if (linhas.Skip(1).Any(l => l.Split(',')[1] == nome))
                {
                    MessageBox.Show("Este usuario já está cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                linhas.Add($"{nome},{senha}");
            }

            File.WriteAllLines(csvUsuario, linhas);
            MessageBox.Show("Dados salvos com sucesso!");

            txbUsuario.Clear();
            txbSenha.Clear();

            CarregarCsvNoGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var linhas = new List<string> { "Usuario,Senha" };

                foreach (DataGridViewRow row in dgvUsuario.Rows)
                {
                    if (row.IsNewRow) continue;

                    string usuario = row.Cells[0].Value?.ToString() ?? "";
                    string senha = row.Cells[1].Value?.ToString() ?? "";

                    if (!string.IsNullOrWhiteSpace(usuario) && !string.IsNullOrWhiteSpace(senha))
                    {
                        linhas.Add($"{usuario},{senha}");
                    }
                }

                File.WriteAllLines(csvUsuario, linhas);
                MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarCsvNoGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar as alterações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
