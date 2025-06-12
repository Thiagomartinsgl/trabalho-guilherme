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
        private string caminhoClientes = "C:/Users/thiag/Documents/csvClientes";
        private string caminhoProdutos = "C:/Users/thiag/Documents/csvProdutos";
        private string caminhoPedidos = "C:/Users/thiag/Documents/csvPedidos";

        public FormCadastroPedidos()
        {
            InitializeComponent();
        }

        private void FormCadastroPedidos_Load(object sender, EventArgs e)
        {

        }
    }
}
