namespace SmartTech.Formularios.Base
{
    partial class frmBaseConsulta
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
            cboPesquisaPor = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cboFiltro = new ComboBox();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripRegistros = new ToolStripLabel();
            radioInicia = new RadioButton();
            radioContenha = new RadioButton();
            dgvConsulta = new DataGridView();
            txtConsulta = new SmartTech_Funcoes.Componentes.TextBoxEdit();
            pnlSuperior.SuspendLayout();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.Location = new Point(2, 0);
            pnlSuperior.Size = new Size(764, 39);
            pnlSuperior.TabIndex = 5;
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 36, 38);
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 36, 38);
            btnMinimize.Location = new Point(696, 0);
            // 
            // btnEncerrar
            // 
            btnEncerrar.FlatAppearance.BorderSize = 0;
            btnEncerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 36, 38);
            btnEncerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 36, 38);
            btnEncerrar.Location = new Point(730, 0);
            // 
            // lblTituloFormulario
            // 
            lblTituloFormulario.Location = new Point(6, 11);
            // 
            // cboPesquisaPor
            // 
            cboPesquisaPor.FormattingEnabled = true;
            cboPesquisaPor.Location = new Point(390, 96);
            cboPesquisaPor.Name = "cboPesquisaPor";
            cboPesquisaPor.Size = new Size(182, 25);
            cboPesquisaPor.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(390, 76);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 8;
            label1.Text = "Pesquisar por";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(578, 76);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 10;
            label2.Text = "Filtro";
            // 
            // cboFiltro
            // 
            cboFiltro.FormattingEnabled = true;
            cboFiltro.Location = new Point(578, 96);
            cboFiltro.Name = "cboFiltro";
            cboFiltro.Size = new Size(182, 25);
            cboFiltro.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(2, 480);
            panel1.Name = "panel1";
            panel1.Size = new Size(764, 28);
            panel1.TabIndex = 12;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripRegistros });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(762, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(120, 22);
            toolStripLabel1.Text = "Quantidade Registros";
            // 
            // toolStripRegistros
            // 
            toolStripRegistros.Name = "toolStripRegistros";
            toolStripRegistros.Size = new Size(25, 22);
            toolStripRegistros.Text = "999";
            // 
            // radioInicia
            // 
            radioInicia.AutoSize = true;
            radioInicia.Location = new Point(81, 92);
            radioInicia.Name = "radioInicia";
            radioInicia.Size = new Size(84, 21);
            radioInicia.TabIndex = 13;
            radioInicia.TabStop = true;
            radioInicia.Text = "Inicia com";
            radioInicia.UseVisualStyleBackColor = true;
            // 
            // radioContenha
            // 
            radioContenha.AutoSize = true;
            radioContenha.Location = new Point(212, 92);
            radioContenha.Name = "radioContenha";
            radioContenha.Size = new Size(81, 21);
            radioContenha.TabIndex = 14;
            radioContenha.TabStop = true;
            radioContenha.Text = "Contenha";
            radioContenha.UseVisualStyleBackColor = true;
            // 
            // dgvConsulta
            // 
            dgvConsulta.BackgroundColor = SystemColors.ButtonFace;
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(6, 129);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvConsulta.RowTemplate.Height = 25;
            dgvConsulta.Size = new Size(754, 343);
            dgvConsulta.TabIndex = 11;
            dgvConsulta.DoubleClick += dgvConsulta_DoubleClick;
            // 
            // txtConsulta
            // 
            txtConsulta.BorderStyle = BorderStyle.FixedSingle;
            txtConsulta.Location = new Point(8, 45);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(752, 25);
            txtConsulta.TabIndex = 0;
            txtConsulta.TextChanged += txtConsulta_TextChanged;
            txtConsulta.KeyDown += txtConsulta_KeyDown;
            // 
            // frmBaseConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 510);
            Controls.Add(txtConsulta);
            Controls.Add(radioContenha);
            Controls.Add(radioInicia);
            Controls.Add(panel1);
            Controls.Add(dgvConsulta);
            Controls.Add(label2);
            Controls.Add(cboFiltro);
            Controls.Add(label1);
            Controls.Add(cboPesquisaPor);
            Name = "frmBaseConsulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "r";
            Load += frmBaseConsulta_Load;
            KeyDown += frmBaseConsulta_KeyDown;
            Controls.SetChildIndex(cboPesquisaPor, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(cboFiltro, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(dgvConsulta, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(radioInicia, 0);
            Controls.SetChildIndex(radioContenha, 0);
            Controls.SetChildIndex(pnlSuperior, 0);
            Controls.SetChildIndex(txtConsulta, 0);
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Panel panel1;
        protected RadioButton radioInicia;
        protected RadioButton radioContenha;
        protected ComboBox cboPesquisaPor;
        protected ComboBox cboFiltro;
        protected ToolStrip toolStrip1;
        protected DataGridView dgvConsulta;
        protected ToolStripLabel toolStripLabel1;
        protected ToolStripLabel toolStripRegistros;
        protected SmartTech_Funcoes.Componentes.TextBoxEdit txtConsulta;
    }
}