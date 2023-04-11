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
            txtConsulta = new TextBox();
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
            pnlSuperior.SuspendLayout();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.Location = new Point(2, 0);
            pnlSuperior.Size = new Size(764, 34);
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
            // txtConsulta
            // 
            txtConsulta.Location = new Point(6, 43);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(754, 23);
            txtConsulta.TabIndex = 6;
            // 
            // cboPesquisaPor
            // 
            cboPesquisaPor.FormattingEnabled = true;
            cboPesquisaPor.Location = new Point(390, 85);
            cboPesquisaPor.Name = "cboPesquisaPor";
            cboPesquisaPor.Size = new Size(182, 23);
            cboPesquisaPor.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(390, 67);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 8;
            label1.Text = "Pesquisar por";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(578, 67);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 10;
            label2.Text = "Filtro";
            // 
            // cboFiltro
            // 
            cboFiltro.FormattingEnabled = true;
            cboFiltro.Location = new Point(578, 85);
            cboFiltro.Name = "cboFiltro";
            cboFiltro.Size = new Size(182, 23);
            cboFiltro.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(2, 423);
            panel1.Name = "panel1";
            panel1.Size = new Size(764, 25);
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
            radioInicia.Location = new Point(81, 81);
            radioInicia.Name = "radioInicia";
            radioInicia.Size = new Size(80, 19);
            radioInicia.TabIndex = 13;
            radioInicia.TabStop = true;
            radioInicia.Text = "Inicia com";
            radioInicia.UseVisualStyleBackColor = true;
            // 
            // radioContenha
            // 
            radioContenha.AutoSize = true;
            radioContenha.Location = new Point(212, 81);
            radioContenha.Name = "radioContenha";
            radioContenha.Size = new Size(77, 19);
            radioContenha.TabIndex = 14;
            radioContenha.TabStop = true;
            radioContenha.Text = "Contenha";
            radioContenha.UseVisualStyleBackColor = true;
            // 
            // dgvConsulta
            // 
            dgvConsulta.BackgroundColor = SystemColors.ButtonFace;
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(6, 114);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvConsulta.RowTemplate.Height = 25;
            dgvConsulta.Size = new Size(754, 303);
            dgvConsulta.TabIndex = 11;
            dgvConsulta.DoubleClick += dgvConsulta_DoubleClick;
            // 
            // frmBaseConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 450);
            Controls.Add(radioContenha);
            Controls.Add(radioInicia);
            Controls.Add(panel1);
            Controls.Add(dgvConsulta);
            Controls.Add(label2);
            Controls.Add(cboFiltro);
            Controls.Add(label1);
            Controls.Add(cboPesquisaPor);
            Controls.Add(txtConsulta);
            Name = "frmBaseConsulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "r";
            Controls.SetChildIndex(txtConsulta, 0);
            Controls.SetChildIndex(cboPesquisaPor, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(cboFiltro, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(dgvConsulta, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(radioInicia, 0);
            Controls.SetChildIndex(radioContenha, 0);
            Controls.SetChildIndex(pnlSuperior, 0);
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
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripRegistros;
        protected RadioButton radioInicia;
        protected RadioButton radioContenha;
        protected TextBox txtConsulta;
        protected ComboBox cboPesquisaPor;
        protected ComboBox cboFiltro;
        protected ToolStrip toolStrip1;
        protected DataGridView dgvConsulta;
    }
}