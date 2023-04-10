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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            pnlBase.SuspendLayout();
            pnlSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Size = new Size(538, 55);
            // 
            // btnAdicionar
            // 
            btnAdicionar.FlatAppearance.BorderSize = 0;
            // 
            // btnProcurar
            // 
            btnProcurar.FlatAppearance.BorderSize = 0;
            // 
            // btnExcluir
            // 
            btnExcluir.FlatAppearance.BorderSize = 0;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.FlatAppearance.BorderSize = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            // 
            // pnlBase
            // 
            pnlBase.Controls.Add(textBox3);
            pnlBase.Controls.Add(label3);
            pnlBase.Controls.Add(textBox2);
            pnlBase.Controls.Add(label2);
            pnlBase.Controls.Add(textBox1);
            pnlBase.Controls.Add(label1);
            pnlBase.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pnlBase.Size = new Size(538, 159);
            // 
            // pnlSuperior
            // 
            pnlSuperior.Size = new Size(538, 34);
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
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 0;
            label1.Text = "Cód. Município";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(380, 25);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 77);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(420, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 25);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(420, 77);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 4;
            label3.Text = "Estado";
            // 
            // frmCadMunicipios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 250);
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

        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}