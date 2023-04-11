﻿using System;
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
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            pnlBase.Enabled = false;
        }

        public override void MontaTela()
        {
            base.MontaTela();
            LimparCamposTextBox(pnlBase);
        }

        private void LimparCamposTextBox(Panel panel)
        {
            foreach (Control controle in panel.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            LimparCamposTextBox(pnlBase);
            btnAdicionar.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnProcurar.Enabled = false;
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
            btnProcurar.Enabled = true;
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
            btnProcurar.Enabled = false;
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
            btnProcurar.Enabled = true;
            pnlBase.Enabled = false;
        }

        private void frmBaseCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void frmBaseCadastro_Load(object sender, EventArgs e)
        {
            btnAdicionar.Focus();
        }
    }
}
