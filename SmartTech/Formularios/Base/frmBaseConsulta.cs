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
    public partial class frmBaseConsulta : frmBase
    {
        public frmBaseConsulta()
        {
            InitializeComponent();
            radioContenha.Checked = true;
            dgvConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsulta.TabStop = false;
            this.KeyPreview = true; // definir KeyPreview como true
            txtConsulta.Focus(); // definir o foco em txtConsulta

        }

        public virtual bool Func_PegaRegistroSelecionado()
        {
            return true;
        }

        public virtual bool Func_TextChanged()
        {
            return true;
        }

        private void dgvConsulta_DoubleClick(object sender, EventArgs e)
        {
            Func_PegaRegistroSelecionado();
            this.Close();
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            Func_TextChanged();
        }

        private void frmBaseConsulta_Load(object sender, EventArgs e)
        {
            txtConsulta.Focus();
        }

        private void txtConsulta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && dgvConsulta.CurrentRow != null && dgvConsulta.CurrentRow.Index < dgvConsulta.Rows.Count - 1)
            {
                // mover para a próxima linha do DataGridView
                dgvConsulta.CurrentCell = dgvConsulta.Rows[dgvConsulta.CurrentRow.Index + 1].Cells[0];
                e.Handled = true; // marcar o evento como tratado para que o txtConsulta não perca o foco
            }
            else if (e.KeyCode == Keys.Up && dgvConsulta.CurrentRow != null && dgvConsulta.CurrentRow.Index > 0)
            {
                // mover para a linha anterior do DataGridView
                dgvConsulta.CurrentCell = dgvConsulta.Rows[dgvConsulta.CurrentRow.Index - 1].Cells[0];
                e.Handled = true; // marcar o evento como tratado para que o txtConsulta não perca o foco
            }

            if (e.KeyCode == Keys.Enter)
            {
                Func_PegaRegistroSelecionado();
                this.Close();
                e.Handled = true; // marque o evento como tratado para evitar que o DataGridView processe o evento Enter
            }
        }
    }
}
