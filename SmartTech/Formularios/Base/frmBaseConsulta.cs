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
    public partial class frmBaseConsulta : frmBase
    {
        public frmBaseConsulta()
        {
            InitializeComponent();
            dgvConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public virtual bool Func_PegaRegistroSelecionado()
        {
            return true;
        }

        private void dgvConsulta_DoubleClick(object sender, EventArgs e)
        {
            Func_PegaRegistroSelecionado();
            this.Close();
        }
    }
}