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
                txtCodigo.Text = municipio.Codigo.ToString();
                txtNome.Text = municipio.Nome;
                txtEstado.Text = municipio.Estado;

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
    }
}
