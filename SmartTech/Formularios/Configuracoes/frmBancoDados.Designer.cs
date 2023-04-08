namespace SmartTech.Formularios.Configuracoes
{
    partial class frmBancoDados
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
            button1 = new Button();
            pnlSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.Size = new Size(429, 34);
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 36, 38);
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 36, 38);
            btnMinimize.Location = new Point(361, 0);
            // 
            // btnEncerrar
            // 
            btnEncerrar.FlatAppearance.BorderSize = 0;
            btnEncerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 36, 38);
            btnEncerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 36, 38);
            btnEncerrar.Location = new Point(395, 0);
            // 
            // button1
            // 
            button1.Location = new Point(132, 134);
            button1.Name = "button1";
            button1.Size = new Size(150, 23);
            button1.TabIndex = 6;
            button1.Text = "Testar Conexao";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmBancoDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 261);
            Controls.Add(button1);
            Name = "frmBancoDados";
            Text = "frmBancoDados";
            Controls.SetChildIndex(pnlSuperior, 0);
            Controls.SetChildIndex(button1, 0);
            pnlSuperior.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}