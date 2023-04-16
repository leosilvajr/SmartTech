using SmartTech.Formularios.Base;
using SmartTech.Formularios.Consultas;
using SmartTech_Funcoes;
using SmartTech_Funcoes.DAO;
using SmartTech_Funcoes.Entidades;

namespace SmartTech.Formularios.Cadastros
{
    public partial class frmCadClientes : frmBaseCadastro
    {
        Cliente cliente;
        public Util.DelegateRetornoConsulta<Cliente> SetRetornoConsultaCallback;
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
    }
}
