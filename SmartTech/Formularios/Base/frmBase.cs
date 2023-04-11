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
    public partial class frmBase : Form
    {
        //Variavel que adiciona Sombra no Form
        private const int CS_DROPSHADOW = 0x00020000;

        //Variaveis para arrastar Panel Topo
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public frmBase()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.FormBorderStyle = FormBorderStyle.None;

        }

        public virtual void MontaTela()
        {

        }


        //Propriedade que Adiciona Sombra no Formulario
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnlSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
