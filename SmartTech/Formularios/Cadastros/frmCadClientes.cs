using SmartTech.Formularios.Base;
using SmartTech.Formularios.Consultas;
using SmartTech_Funcoes;
using SmartTech_Funcoes.DAO;
using SmartTech_Funcoes.Entidades;
using System.Windows.Forms;

namespace SmartTech.Formularios.Cadastros
{
    public partial class frmCadClientes : frmBaseCadastro
    {
        Cliente cliente;
        public Util.DelegateRetornoConsulta<Cliente> SetRetornoConsultaCallback;
        Municipio municipio;
        public Util.DelegateRetornoConsulta<Municipio> SetRetornoConsultaCallbackMunicipio;
        public frmCadClientes()
        {
            InitializeComponent();
            cliente = new Cliente();
            lblTituloFormulario.Text = "Cadastro de Clientes";
            cboPessoa.SelectedIndex = 0;
        }

        private void cboPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPessoa.SelectedIndex == 0)
            {
                mskCpfCnpj.CPF = true;
                mskCpfCnpj.CNPJ = false;
            }
            else if (cboPessoa.SelectedIndex == 1)
            {
                mskCpfCnpj.CPF = false;
                mskCpfCnpj.CNPJ = true;
            }
        }

        public override void MontaTela()
        {
            base.MontaTela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            Cliente clienteExistente = dao.ObterPorCodigo(cliente.Codigo);

            if (clienteExistente != null)
            {
                // Atualiza os dados do registro existente
                clienteExistente.NomeRazaoSocial = txtNome.Text;
                clienteExistente.Pessoa = cboPessoa.Text;
                clienteExistente.NomeRazaoSocial = txtNome.Text;
                clienteExistente.ApelidoFantasia = txtApelidoFantasia.Text;
                clienteExistente.CpfCnpj = mskCpfCnpj.GetTextSemMascara();
                clienteExistente.IeRg = txtRgIe.Text;
                clienteExistente.CodMunicipio = int.Parse(txtCodMunicipio.Text);
                clienteExistente.Endereco = txtEndereco.Text;
                clienteExistente.Numero = txtNumero.Text;
                clienteExistente.Cep = mkbCep.GetTextSemMascara();
                clienteExistente.Bairro = txtBairro.Text;
                clienteExistente.Celular = mkbCelular.GetTextSemMascara();
                clienteExistente.Telefone = mkbTelefone.GetTextSemMascara();
                clienteExistente.Email = txtEmail.Text;
                dao.Atualizar(clienteExistente);

                MessageBox.Show("Cliente atualizado com sucesso!");
                MontaTela();

            }
            else
            {
                // Cria um novo registro
                Cliente clienteNovo = new Cliente();
                clienteNovo.NomeRazaoSocial = txtNome.Text;
                clienteNovo.Pessoa = cboPessoa.Text;
                clienteNovo.NomeRazaoSocial = txtNome.Text;
                clienteNovo.ApelidoFantasia = txtApelidoFantasia.Text;
                clienteNovo.CpfCnpj = mskCpfCnpj.GetTextSemMascara();
                clienteNovo.IeRg = txtRgIe.Text;
                clienteNovo.CodMunicipio = int.Parse(txtCodMunicipio.Text);
                clienteNovo.Endereco = txtEndereco.Text;
                clienteNovo.Numero = txtNumero.Text;
                clienteNovo.Cep = mkbCep.Text;
                clienteNovo.Bairro = txtBairro.Text;
                clienteNovo.Celular = mkbCelular.GetTextSemMascara();
                clienteNovo.Telefone = mkbTelefone.GetTextSemMascara();
                clienteNovo.Email = txtEmail.Text;

                dao.Inserir(clienteNovo);

                MessageBox.Show("Cliente salvo com sucesso!");
                MontaTela();
            }
        }

        private void RetornoConsultaCallbackFnM(Cliente entidade)
        {
            try
            {
                txtCodigo.Text = entidade.Codigo.ToString();
                txtNome.Text = entidade.NomeRazaoSocial;
                mskCpfCnpj.Text = entidade.CpfCnpj;
                txtApelidoFantasia.Text = entidade.ApelidoFantasia;
                txtCodMunicipio.Text = entidade.CodMunicipio.ToString();
                lblMunicipio.Text = entidade.NomeMunicipio;
                lblUf.Text = entidade.Estado;
                txtEndereco.Text = entidade.Endereco;
                txtNumero.Text = entidade.Numero;
                txtBairro.Text = entidade.Bairro;
                mkbTelefone.Text = entidade.Telefone;
                mkbCelular.Text = entidade.Celular;
                txtEmail.Text = entidade.Email;
                cboPessoa.Text = entidade.Pessoa;
                mkbCep.Text = entidade.Cep;

            }
            catch (Exception ex)
            {

                Mensagem.MostraErro(ex.Message);
            }
        }

        private void RetornoConsultaCallbackFnMunicipio(Municipio entidade)
        {
            try
            {
                txtCodMunicipio.Text = entidade.Codigo.ToString();
                lblMunicipio.Text = entidade.Nome;
                lblUf.Text = entidade.Estado;

            }
            catch (Exception ex)
            {

                Mensagem.MostraErro(ex.Message);
            }
        }
        private void txtCodMunicipio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                frmConsultaMunicipio consultaMunicipio = new frmConsultaMunicipio();
                consultaMunicipio.SetRetornoConsultaCallback = new Util.DelegateRetornoConsulta<Municipio>(RetornoConsultaCallbackFnMunicipio);
                Util.AbreForm(this, consultaMunicipio);
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            frmConsultaClientes consulta = new frmConsultaClientes();
            consulta.SetRetornoConsultaCallback = new Util.DelegateRetornoConsulta<Cliente>(RetornoConsultaCallbackFnM);
            Util.AbreForm(this, consulta);
        }
    }
}
