using System.Data;

namespace trabalho
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        private string csvLogin = "C:/Users/thiag/Documents/csvLogin.txt";

        public FormLogin()
        {
            InitializeComponent();
            InicializarCsvSeNecessario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InicializarCsvSeNecessario()
        {
            if (!File.Exists(csvLogin))
            {
                using (StreamWriter sw = new StreamWriter(csvLogin))
                {
                    sw.WriteLine("Usuario,Senha");
                }
            }
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
