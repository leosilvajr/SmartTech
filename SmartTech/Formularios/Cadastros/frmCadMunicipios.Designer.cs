namespace SmartTech.Formularios.Cadastros
{
    partial class frmCadMunicipios
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCodigo = new SmartTech_Funcoes.Componentes.TextBoxEdit();
            txtNome = new SmartTech_Funcoes.Componentes.TextBoxEdit();
            cboEstado = new SmartTech_Funcoes.Componentes.ComboBoxEdit();
            panel1.SuspendLayout();
            pnlBase.SuspendLayout();
            pnlSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Size = new Size(538, 62);
            // 
            // btnAdicionar
            // 
            btnAdicionar.FlatAppearance.BorderSize = 0;
            // 
            // btnProcurar
            // 
            btnProcurar.FlatAppearance.BorderSize = 0;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            // 
            // pnlBase
            // 
            pnlBase.Controls.Add(cboEstado);
            pnlBase.Controls.Add(txtNome);
            pnlBase.Controls.Add(txtCodigo);
            pnlBase.Controls.Add(label3);
            pnlBase.Controls.Add(label2);
            pnlBase.Controls.Add(label1);
            pnlBase.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pnlBase.Size = new Size(538, 180);
            // 
            // pnlSuperior
            // 
            pnlSuperior.Size = new Size(538, 39);
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 36, 38);
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 36, 38);
            btnMinimize.Location = new Point(470, 0);
            // 
            // btnEncerrar
            // 
            btnEncerrar.FlatAppearance.BorderSize = 0;
            btnEncerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 36, 38);
            btnEncerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 36, 38);
            btnEncerrar.Location = new Point(504, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 28);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 0;
            label1.Text = "Cód. Município";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 87);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(429, 87);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 4;
            label3.Text = "Estado";
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(20, 48);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 25);
            txtCodigo.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(20, 107);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(365, 25);
            txtNome.TabIndex = 6;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(429, 107);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(75, 25);
            cboEstado.TabIndex = 7;
            // 
            // frmCadMunicipios
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 283);
            Name = "frmCadMunicipios";
            Text = "frmCadMunicipios";
            panel1.ResumeLayout(false);
            pnlBase.ResumeLayout(false);
            pnlBase.PerformLayout();
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private SmartTech_Funcoes.Componentes.TextBoxEdit txtEstado;
        private SmartTech_Funcoes.Componentes.TextBoxEdit txtNome;
        private SmartTech_Funcoes.Componentes.TextBoxEdit txtCodigo;
        private SmartTech_Funcoes.Componentes.ComboBoxEdit cboEstado;
    }
}