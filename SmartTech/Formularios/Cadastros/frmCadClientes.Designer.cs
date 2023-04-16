namespace SmartTech.Formularios.Cadastros
{
    partial class frmCadClientes
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
            txtNome = new SmartTech_Funcoes.Componentes.TextBoxEdit();
            txtCodigo = new SmartTech_Funcoes.Componentes.TextBoxEdit();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            mskCpfCnpj = new SmartTech_Funcoes.Componentes.MaskedTextBoxEdit();
            label3 = new Label();
            txtRgIe = new SmartTech_Funcoes.Componentes.TextBoxEdit();
            label4 = new Label();
            txtApelidoFantasia = new SmartTech_Funcoes.Componentes.TextBoxEdit();
            label5 = new Label();
            cboPessoa = new SmartTech_Funcoes.Componentes.ComboBoxEdit();
            label6 = new Label();
            txtCodMunicipio = new SmartTech_Funcoes.Componentes.TextBoxEdit();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblMunicipio = new Label();
            lblUf = new Label();
            txtEndereco = new SmartTech_Funcoes.Componentes.TextBoxEdit();
            label12 = new Label();
            txtNumero = new SmartTech_Funcoes.Componentes.TextBoxEdit();
            label13 = new Label();
            txtBairro = new SmartTech_Funcoes.Componentes.TextBoxEdit();
            label14 = new Label();
            label15 = new Label();
            mskCelular = new SmartTech_Funcoes.Componentes.MaskedTextBoxEdit();
            label16 = new Label();
            mskTelefone = new SmartTech_Funcoes.Componentes.MaskedTextBoxEdit();
            txtEmail = new SmartTech_Funcoes.Componentes.TextBoxEdit();
            label17 = new Label();
            label10 = new Label();
            maskedTextBoxEdit1 = new SmartTech_Funcoes.Componentes.MaskedTextBoxEdit();
            btnAnexarImagem = new SmartTech_Funcoes.Componentes.ButtonEdit();
            panel1.SuspendLayout();
            pnlBase.SuspendLayout();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Size = new Size(851, 62);
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
            pnlBase.Controls.Add(btnAnexarImagem);
            pnlBase.Controls.Add(label10);
            pnlBase.Controls.Add(maskedTextBoxEdit1);
            pnlBase.Controls.Add(txtEmail);
            pnlBase.Controls.Add(label17);
            pnlBase.Controls.Add(label16);
            pnlBase.Controls.Add(mskTelefone);
            pnlBase.Controls.Add(label15);
            pnlBase.Controls.Add(mskCelular);
            pnlBase.Controls.Add(txtBairro);
            pnlBase.Controls.Add(label14);
            pnlBase.Controls.Add(txtNumero);
            pnlBase.Controls.Add(label13);
            pnlBase.Controls.Add(txtEndereco);
            pnlBase.Controls.Add(label12);
            pnlBase.Controls.Add(lblUf);
            pnlBase.Controls.Add(lblMunicipio);
            pnlBase.Controls.Add(label9);
            pnlBase.Controls.Add(label8);
            pnlBase.Controls.Add(txtCodMunicipio);
            pnlBase.Controls.Add(label7);
            pnlBase.Controls.Add(label6);
            pnlBase.Controls.Add(cboPessoa);
            pnlBase.Controls.Add(txtApelidoFantasia);
            pnlBase.Controls.Add(label5);
            pnlBase.Controls.Add(txtRgIe);
            pnlBase.Controls.Add(label4);
            pnlBase.Controls.Add(label3);
            pnlBase.Controls.Add(mskCpfCnpj);
            pnlBase.Controls.Add(pictureBox1);
            pnlBase.Controls.Add(txtNome);
            pnlBase.Controls.Add(txtCodigo);
            pnlBase.Controls.Add(label2);
            pnlBase.Controls.Add(label1);
            pnlBase.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            pnlBase.Size = new Size(851, 320);
            pnlBase.Paint += pnlBase_Paint;
            // 
            // pnlSuperior
            // 
            pnlSuperior.Size = new Size(851, 39);
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 36, 38);
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 36, 38);
            btnMinimize.Location = new Point(783, 0);
            // 
            // btnEncerrar
            // 
            btnEncerrar.FlatAppearance.BorderSize = 0;
            btnEncerrar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnEncerrar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnEncerrar.Location = new Point(817, 0);
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(155, 84);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(547, 25);
            txtNome.TabIndex = 10;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Enabled = false;
            txtCodigo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(156, 22);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(121, 25);
            txtCodigo.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 88);
            label2.Name = "label2";
            label2.Size = new Size(127, 17);
            label2.TabIndex = 8;
            label2.Text = "Nome/Razão Social";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 26);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 7;
            label1.Text = "Cód. Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(721, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 117);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // mskCpfCnpj
            // 
            mskCpfCnpj.BorderStyle = BorderStyle.FixedSingle;
            mskCpfCnpj.CPF = true;
            mskCpfCnpj.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            mskCpfCnpj.Location = new Point(155, 147);
            mskCpfCnpj.Mask = "000,000,000-00";
            mskCpfCnpj.Name = "mskCpfCnpj";
            mskCpfCnpj.Size = new Size(122, 25);
            mskCpfCnpj.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 152);
            label3.Name = "label3";
            label3.Size = new Size(76, 17);
            label3.TabIndex = 13;
            label3.Text = "CPF / CNPJ";
            // 
            // txtRgIe
            // 
            txtRgIe.BorderStyle = BorderStyle.FixedSingle;
            txtRgIe.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtRgIe.Location = new Point(566, 147);
            txtRgIe.Name = "txtRgIe";
            txtRgIe.Size = new Size(136, 25);
            txtRgIe.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(433, 152);
            label4.Name = "label4";
            label4.Size = new Size(127, 17);
            label4.TabIndex = 14;
            label4.Text = "RG / Inscr. Estadual";
            // 
            // txtApelidoFantasia
            // 
            txtApelidoFantasia.BorderStyle = BorderStyle.FixedSingle;
            txtApelidoFantasia.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApelidoFantasia.Location = new Point(156, 116);
            txtApelidoFantasia.Name = "txtApelidoFantasia";
            txtApelidoFantasia.Size = new Size(546, 25);
            txtApelidoFantasia.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 120);
            label5.Name = "label5";
            label5.Size = new Size(113, 17);
            label5.TabIndex = 16;
            label5.Text = "Apelido/Fantasia";
            // 
            // cboPessoa
            // 
            cboPessoa.DropDownHeight = 90;
            cboPessoa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboPessoa.FormattingEnabled = true;
            cboPessoa.IntegralHeight = false;
            cboPessoa.Items.AddRange(new object[] { "Fisica", "Juridica" });
            cboPessoa.Location = new Point(156, 53);
            cboPessoa.Name = "cboPessoa";
            cboPessoa.Size = new Size(121, 25);
            cboPessoa.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(11, 56);
            label6.Name = "label6";
            label6.Size = new Size(50, 17);
            label6.TabIndex = 19;
            label6.Text = "Pessoa";
            // 
            // txtCodMunicipio
            // 
            txtCodMunicipio.BorderStyle = BorderStyle.FixedSingle;
            txtCodMunicipio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodMunicipio.Location = new Point(155, 178);
            txtCodMunicipio.Name = "txtCodMunicipio";
            txtCodMunicipio.Size = new Size(122, 25);
            txtCodMunicipio.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(11, 182);
            label7.Name = "label7";
            label7.Size = new Size(130, 17);
            label7.TabIndex = 20;
            label7.Text = "Cód. Municipio (F3)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(313, 182);
            label8.Name = "label8";
            label8.Size = new Size(54, 17);
            label8.TabIndex = 22;
            label8.Text = "Cidade:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(682, 182);
            label9.Name = "label9";
            label9.Size = new Size(53, 17);
            label9.TabIndex = 23;
            label9.Text = "Estado:";
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMunicipio.Location = new Point(373, 182);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(123, 17);
            lblMunicipio.TabIndex = 24;
            lblMunicipio.Text = "<CAMPO CIDADE>";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUf.Location = new Point(740, 182);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(93, 17);
            lblUf.TabIndex = 25;
            lblUf.Text = "<CAMPO UF>";
            // 
            // txtEndereco
            // 
            txtEndereco.BorderStyle = BorderStyle.FixedSingle;
            txtEndereco.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.Location = new Point(155, 209);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(403, 25);
            txtEndereco.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(11, 213);
            label12.Name = "label12";
            label12.Size = new Size(64, 17);
            label12.TabIndex = 26;
            label12.Text = "Endereço";
            // 
            // txtNumero
            // 
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(630, 209);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(62, 25);
            txtNumero.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(564, 213);
            label13.Name = "label13";
            label13.Size = new Size(58, 17);
            label13.TabIndex = 28;
            label13.Text = "Número";
            // 
            // txtBairro
            // 
            txtBairro.BorderStyle = BorderStyle.FixedSingle;
            txtBairro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.Location = new Point(155, 240);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(403, 25);
            txtBairro.TabIndex = 31;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(11, 244);
            label14.Name = "label14";
            label14.Size = new Size(45, 17);
            label14.TabIndex = 30;
            label14.Text = "Bairro";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(11, 273);
            label15.Name = "label15";
            label15.Size = new Size(51, 17);
            label15.TabIndex = 33;
            label15.Text = "Celular";
            // 
            // mskCelular
            // 
            mskCelular.BorderStyle = BorderStyle.FixedSingle;
            mskCelular.CELULAR = true;
            mskCelular.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            mskCelular.Location = new Point(155, 271);
            mskCelular.Mask = "(00) 00000-0000";
            mskCelular.Name = "mskCelular";
            mskCelular.Size = new Size(99, 25);
            mskCelular.TabIndex = 32;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(271, 273);
            label16.Name = "label16";
            label16.Size = new Size(61, 17);
            label16.TabIndex = 35;
            label16.Text = "Telefone";
            // 
            // mskTelefone
            // 
            mskTelefone.BorderStyle = BorderStyle.FixedSingle;
            mskTelefone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            mskTelefone.Location = new Point(338, 271);
            mskTelefone.Mask = "(00)0000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(109, 25);
            mskTelefone.TabIndex = 34;
            mskTelefone.TELEFONE = true;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(550, 271);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(283, 25);
            txtEmail.TabIndex = 37;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(463, 279);
            label17.Name = "label17";
            label17.Size = new Size(47, 17);
            label17.TabIndex = 36;
            label17.Text = "E-Mail";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(698, 213);
            label10.Name = "label10";
            label10.Size = new Size(31, 17);
            label10.TabIndex = 39;
            label10.Text = "CEP";
            // 
            // maskedTextBoxEdit1
            // 
            maskedTextBoxEdit1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxEdit1.CEP = true;
            maskedTextBoxEdit1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxEdit1.Location = new Point(735, 209);
            maskedTextBoxEdit1.Mask = "00000-000";
            maskedTextBoxEdit1.Name = "maskedTextBoxEdit1";
            maskedTextBoxEdit1.Size = new Size(98, 25);
            maskedTextBoxEdit1.TabIndex = 38;
            // 
            // btnAnexarImagem
            // 
            btnAnexarImagem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnexarImagem.Location = new Point(720, 145);
            btnAnexarImagem.Name = "btnAnexarImagem";
            btnAnexarImagem.Size = new Size(112, 26);
            btnAnexarImagem.TabIndex = 40;
            btnAnexarImagem.Text = "Anexar";
            btnAnexarImagem.TextAlign = ContentAlignment.TopCenter;
            btnAnexarImagem.UseVisualStyleBackColor = true;
            // 
            // frmCadClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 423);
            Name = "frmCadClientes";
            Text = "frmCadClientes";
            panel1.ResumeLayout(false);
            pnlBase.ResumeLayout(false);
            pnlBase.PerformLayout();
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SmartTech_Funcoes.Componentes.TextBoxEdit txtNome;
        private SmartTech_Funcoes.Componentes.TextBoxEdit txtCodigo;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private SmartTech_Funcoes.Componentes.TextBoxEdit txtRgIe;
        private Label label4;
        private Label label3;
        private SmartTech_Funcoes.Componentes.MaskedTextBoxEdit mskCpfCnpj;
        private SmartTech_Funcoes.Componentes.TextBoxEdit txtApelidoFantasia;
        private Label label5;
        private Label label6;
        private SmartTech_Funcoes.Componentes.ComboBoxEdit cboPessoa;
        private Label lblUf;
        private Label lblMunicipio;
        private Label label9;
        private Label label8;
        private SmartTech_Funcoes.Componentes.TextBoxEdit txtCodMunicipio;
        private Label label7;
        private SmartTech_Funcoes.Componentes.TextBoxEdit txtEndereco;
        private Label label12;
        private SmartTech_Funcoes.Componentes.TextBoxEdit txtNumero;
        private Label label13;
        private SmartTech_Funcoes.Componentes.TextBoxEdit txtBairro;
        private Label label14;
        private SmartTech_Funcoes.Componentes.TextBoxEdit txtEmail;
        private Label label17;
        private Label label16;
        private SmartTech_Funcoes.Componentes.MaskedTextBoxEdit mskTelefone;
        private Label label15;
        private SmartTech_Funcoes.Componentes.MaskedTextBoxEdit mskCelular;
        private Label label10;
        private SmartTech_Funcoes.Componentes.MaskedTextBoxEdit maskedTextBoxEdit1;
        private SmartTech_Funcoes.Componentes.ButtonEdit btnAnexarImagem;
    }
}