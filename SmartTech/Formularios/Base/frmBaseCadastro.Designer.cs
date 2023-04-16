namespace SmartTech.Formularios.Base
{
    partial class frmBaseCadastro
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseCadastro));
            panel1 = new Panel();
            btnProcurar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnAdicionar = new Button();
            toolTip1 = new ToolTip(components);
            pnlBase = new Panel();
            pnlRodape = new SmartTech_Funcoes.Componentes.PanelEdit();
            pnlSuperior.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.Location = new Point(2, 0);
            pnlSuperior.Size = new Size(796, 39);
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 36, 38);
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 36, 38);
            btnMinimize.Location = new Point(728, 0);
            // 
            // lblTituloFormulario
            // 
            lblTituloFormulario.Location = new Point(6, 11);
            // 
            // btnEncerrar
            // 
            btnEncerrar.FlatAppearance.BorderSize = 0;
            btnEncerrar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnEncerrar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnEncerrar.Location = new Point(762, 0);
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnProcurar);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnAdicionar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(2, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 62);
            panel1.TabIndex = 6;
            // 
            // btnProcurar
            // 
            btnProcurar.Dock = DockStyle.Left;
            btnProcurar.FlatAppearance.BorderSize = 0;
            btnProcurar.FlatStyle = FlatStyle.Flat;
            btnProcurar.Image = (Image)resources.GetObject("btnProcurar.Image");
            btnProcurar.Location = new Point(295, 0);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(59, 60);
            btnProcurar.TabIndex = 5;
            btnProcurar.Tag = "Procurar";
            toolTip1.SetToolTip(btnProcurar, "Procurar");
            btnProcurar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Dock = DockStyle.Left;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new Point(236, 0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(59, 60);
            btnExcluir.TabIndex = 4;
            btnExcluir.Tag = "Excluir Registro";
            toolTip1.SetToolTip(btnExcluir, "Excluir Registro");
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Dock = DockStyle.Left;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(177, 0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(59, 60);
            btnEditar.TabIndex = 3;
            btnEditar.Tag = "Editar Registro";
            toolTip1.SetToolTip(btnEditar, "Editar Registro");
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Dock = DockStyle.Left;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(118, 0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(59, 60);
            btnSalvar.TabIndex = 2;
            btnSalvar.Tag = "Salvar Registro";
            toolTip1.SetToolTip(btnSalvar, "Salvar Registro");
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Left;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(59, 0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(59, 60);
            btnCancelar.TabIndex = 1;
            btnCancelar.Tag = "Cancelar Ação";
            toolTip1.SetToolTip(btnCancelar, "Cancelar Ação");
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Dock = DockStyle.Left;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Image = Properties.Resources.plus;
            btnAdicionar.Location = new Point(0, 0);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(59, 60);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Tag = "Adicionar Registro";
            toolTip1.SetToolTip(btnAdicionar, "Adicionar Registro");
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // pnlBase
            // 
            pnlBase.BackColor = Color.Lavender;
            pnlBase.Dock = DockStyle.Fill;
            pnlBase.Location = new Point(2, 101);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(796, 407);
            pnlBase.TabIndex = 7;
            // 
            // pnlRodape
            // 
            pnlRodape.BackColor = Color.FromArgb(25, 25, 27);
            pnlRodape.Dock = DockStyle.Bottom;
            pnlRodape.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            pnlRodape.Location = new Point(2, 489);
            pnlRodape.Name = "pnlRodape";
            pnlRodape.Size = new Size(796, 19);
            pnlRodape.TabIndex = 8;
            // 
            // frmBaseCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(pnlRodape);
            Controls.Add(pnlBase);
            Controls.Add(panel1);
            Name = "frmBaseCadastro";
            Text = "frmBaseCadastro";
            Load += frmBaseCadastro_Load;
            KeyDown += frmBaseCadastro_KeyDown;
            Controls.SetChildIndex(pnlSuperior, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(pnlBase, 0);
            Controls.SetChildIndex(pnlRodape, 0);
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected Panel panel1;
        protected Button btnAdicionar;
        protected Button btnProcurar;
        protected Button btnExcluir;
        protected Button btnEditar;
        protected Button btnSalvar;
        protected Button btnCancelar;
        private Button button1;
        private ToolTip toolTip1;
        protected Panel pnlBase;
        protected SmartTech_Funcoes.Componentes.PanelEdit pnlRodape;
    }
}