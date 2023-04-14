using SmartTech.Formularios.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTech.Formularios.Cadastros
{
    public partial class frmCadClientes : frmBaseCadastro
    {
        public frmCadClientes()
        {
            InitializeComponent();
            lblTituloFormulario.Text = "Cadastro de Clientes";

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pnlBase_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
