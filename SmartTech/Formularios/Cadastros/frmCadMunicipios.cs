using SmartTech.Formularios.Base;
using SmartTech.Formularios.Consultas;
using SmartTech_Funcoes;
using SmartTech_Funcoes.DAO;
using SmartTech_Funcoes.Entidades;

namespace SmartTech.Formularios.Cadastros
{
    public partial class frmCadMunicipios : frmBaseCadastro
    {
        Municipio municipio;
        public Util.DelegateRetornoConsulta<Municipio> SetRetornoConsultaCallback;
        public frmCadMunicipios()
        {
            InitializeComponent();
            municipio = new Municipio();
            lblTituloFormulario.Text = "Cadastro de Municípios";
            MontaComboEstado();
        }

        private void MontaComboEstado()
        {
            cboEstado.DisplayMember = "Descricao";
            cboEstado.ValueMember = "Value";
            cboEstado.PreencheComboEstadosBrasil();
            cboEstado.SelectedIndex = -1;

        }

        public override void MontaTela()
        {
            base.MontaTela();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MunicipioDAO dao = new MunicipioDAO();
            Municipio municipioExistente = dao.ObterPorCodigo(municipio.Codigo);

            if (municipioExistente != null)
            {
                // Atualiza os dados do registro existente
                municipioExistente.Nome = txtNome.Text;
                municipioExistente.Estado = cboEstado.Text;

                dao.Atualizar(municipioExistente);

                Mensagem.MostraAviso("Município atualizado com sucesso.");
                MontaTela();

            }
            else
            {
                // Cria um novo registro
                Municipio novoMunicipio = new Municipio();
                novoMunicipio.Nome = txtNome.Text;
                novoMunicipio.Estado = cboEstado.Text;

                dao.Inserir(novoMunicipio);

                Mensagem.MostraAviso("Município cadastrado com sucesso.");
                MontaTela();
            }
        }

        private void RetornoConsultaCallbackFn(Municipio entidade)
        {
            try
            {
                municipio = entidade;
                txtCodigo.Text = municipio.Codigo.ToString();
                txtNome.Text = municipio.Nome;
                cboEstado.Text = municipio.Estado;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");
            }
        }
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            frmConsultaMunicipio consulta = new frmConsultaMunicipio();
            consulta.SetRetornoConsultaCallback = new Util.DelegateRetornoConsulta<Municipio>(RetornoConsultaCallbackFn);
            Util.AbreForm(this, consulta);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o registro selecionado?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MunicipioDAO dao = new MunicipioDAO();

                int codigo = Convert.ToInt32(txtCodigo.Text);
                dao.Excluir(codigo);

                MessageBox.Show("Município excluído com sucesso!");
                MontaTela();
            }
        }
    }
}
