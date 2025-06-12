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
    public partial class FormPrincipal : System.Windows.Forms.Form
    {
        private string usuarioLogado;

        public FormPrincipal(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCadastroC formClientes = new FormCadastroC();
            formClientes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCadastroP formProdiutos = new FormCadastroP();
            formProdiutos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCadastroPedidos formPedidos = new FormCadastroPedidos();
            formPedidos.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCadastroU formUsuarios = new FormCadastroU(usuarioLogado);
            formUsuarios.ShowDialog();
        }
    }
}
