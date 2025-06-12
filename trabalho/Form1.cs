using System.Data;

namespace trabalho
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        private string csvLogin = "C:/Users/thiag/Documents/csvLogin";

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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (usuario == "ADMIN" && senha == "123")
            {
                AbrirFormularioPrincipal(usuario);
                return;

            }

            if (File.Exists(csvLogin))
            {
                var linhas = File.ReadAllLines(csvLogin).Skip(1);

                foreach (var linha in linhas)
                {
                    var dados = linha.Split(',');
                    if (dados.Length == 2 && dados[0] == usuario && dados[1] == senha)
                    {
                        AbrirFormularioPrincipal(usuario);
                        return;
                    }
                }
            }

            MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void AbrirFormularioPrincipal(string usuario)
        {
            FormPrincipal principal = new FormPrincipal(usuario);
            principal.Show();
        }
    }
}
