using SmartTech.Formularios.Base;
using SmartTech.Formularios.Consultas;
using SmartTech_Funcoes;
using SmartTech_Funcoes.DAO;
using SmartTech_Funcoes.Entidades;
using System.Windows.Forms;

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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Municipio municipio = new Municipio();
            //municipio.Codigo = Convert.ToInt32(txtCodigo.Text);
            municipio.Nome = txtNome.Text;
            municipio.Estado = txtEstado.Text;

            MunicipioDAO dao = new MunicipioDAO();
            dao.Inserir(municipio);

            MessageBox.Show("Município salvo com sucesso!");
        }
        private void RetornoConsultaCallbackFn(Municipio entidade)
        {
            try
            {
                municipio = entidade;
                MontaTela();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");
                //Mensagem.MostraErro(ex.Message);
            }
        }
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            frmConsultaMunicipio consulta = new frmConsultaMunicipio();
            consulta.SetRetornoConsultaCallback = new Util.DelegateRetornoConsulta<Municipio>(RetornoConsultaCallbackFn);
            Util.AbreForm(this, consulta);
        }
    }
}
