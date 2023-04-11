using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTech.Formularios.Base
{
    public partial class frmBaseCadastro : frmBase
    {
        public frmBaseCadastro()
        {
            InitializeComponent();
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            pnlBase.Enabled = false;
        }

        public override void MontaTela()
        {
            //LimpaControles(this.Controls);
            base.MontaTela();
            //IniciarFocusControle(this.Controls);
            //Status = Enums.AcaoTelaStatus.Navegando;

        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            btnAdicionar.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            pnlBase.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnAdicionar.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            pnlBase.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnAdicionar.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            pnlBase.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnAdicionar.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            pnlBase.Enabled = false;
        }
    }
}
