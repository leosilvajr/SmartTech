namespace SmartTech.Formularios.Base
{
    partial class frmBase
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
            pnlSuperior = new Panel();
            btnMinimize = new Button();
            btnEncerrar = new Button();
            pnlEsquerdo = new Panel();
            pnlDireito = new Panel();
            pnlBaixo = new Panel();
            lblTituloFormulario = new Label();
            pnlSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(25, 25, 27);
            pnlSuperior.Controls.Add(lblTituloFormulario);
            pnlSuperior.Controls.Add(btnMinimize);
            pnlSuperior.Controls.Add(btnEncerrar);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(800, 34);
            pnlSuperior.TabIndex = 2;
            pnlSuperior.MouseDown += pnlSuperior_MouseDown;
            pnlSuperior.MouseMove += pnlSuperior_MouseMove;
            pnlSuperior.MouseUp += pnlSuperior_MouseUp;
            // 
            // btnMinimize
            // 
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 36, 38);
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 36, 38);
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Image = Properties.Resources.minimize;
            btnMinimize.Location = new Point(732, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(34, 34);
            btnMinimize.TabIndex = 14;
            btnMinimize.TextAlign = ContentAlignment.MiddleLeft;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnEncerrar
            // 
            btnEncerrar.Dock = DockStyle.Right;
            btnEncerrar.FlatAppearance.BorderSize = 0;
            btnEncerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 36, 38);
            btnEncerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 36, 38);
            btnEncerrar.FlatStyle = FlatStyle.Flat;
            btnEncerrar.ForeColor = Color.White;
            btnEncerrar.Image = Properties.Resources.clos1;
            btnEncerrar.Location = new Point(766, 0);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(34, 34);
            btnEncerrar.TabIndex = 12;
            btnEncerrar.TextAlign = ContentAlignment.MiddleLeft;
            btnEncerrar.UseVisualStyleBackColor = true;
            btnEncerrar.Click += btnEncerrar_Click;
            // 
            // pnlEsquerdo
            // 
            pnlEsquerdo.BackColor = Color.FromArgb(25, 25, 27);
            pnlEsquerdo.Dock = DockStyle.Left;
            pnlEsquerdo.Location = new Point(0, 34);
            pnlEsquerdo.Name = "pnlEsquerdo";
            pnlEsquerdo.Size = new Size(2, 416);
            pnlEsquerdo.TabIndex = 3;
            // 
            // pnlDireito
            // 
            pnlDireito.BackColor = Color.FromArgb(25, 25, 27);
            pnlDireito.Dock = DockStyle.Right;
            pnlDireito.Location = new Point(798, 34);
            pnlDireito.Name = "pnlDireito";
            pnlDireito.Size = new Size(2, 416);
            pnlDireito.TabIndex = 4;
            // 
            // pnlBaixo
            // 
            pnlBaixo.BackColor = Color.FromArgb(25, 25, 27);
            pnlBaixo.Dock = DockStyle.Bottom;
            pnlBaixo.Location = new Point(2, 448);
            pnlBaixo.Name = "pnlBaixo";
            pnlBaixo.Size = new Size(796, 2);
            pnlBaixo.TabIndex = 5;
            // 
            // lblTituloFormulario
            // 
            lblTituloFormulario.AutoSize = true;
            lblTituloFormulario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloFormulario.ForeColor = Color.White;
            lblTituloFormulario.Location = new Point(6, 9);
            lblTituloFormulario.Name = "lblTituloFormulario";
            lblTituloFormulario.Size = new Size(127, 17);
            lblTituloFormulario.TabIndex = 15;
            lblTituloFormulario.Text = "Titulo do Formulario";
            // 
            // frmBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlBaixo);
            Controls.Add(pnlDireito);
            Controls.Add(pnlEsquerdo);
            Controls.Add(pnlSuperior);
            Name = "frmBase";
            Text = "frmBase";
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected Panel pnlSuperior;
        protected Button btnMinimize;
        protected Button btnEncerrar;
        private Panel pnlEsquerdo;
        private Panel pnlDireito;
        private Panel pnlBaixo;
        protected Label lblTituloFormulario;
    }
}