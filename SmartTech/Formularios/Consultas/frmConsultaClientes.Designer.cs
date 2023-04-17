namespace SmartTech.Formularios.Consultas
{
    partial class frmConsultaClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // cboPesquisaPor
            // 
            cboPesquisaPor.Size = new Size(182, 25);
            // 
            // cboFiltro
            // 
            cboFiltro.Size = new Size(182, 25);
            // 
            // pnlSuperior
            // 
            pnlSuperior.Size = new Size(760, 39);
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 36, 38);
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 36, 38);
            btnMinimize.Location = new Point(692, 0);
            // 
            // btnEncerrar
            // 
            btnEncerrar.FlatAppearance.BorderSize = 0;
            btnEncerrar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnEncerrar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnEncerrar.Location = new Point(726, 0);
            // 
            // frmConsultaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 508);
            Name = "frmConsultaClientes";
            Text = "frmConsultaClientes";
            Load += frmConsultaClientes_Load;
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}