using SmartTech.Formularios.Base;
using SmartTech.Formularios.Consultas;
using SmartTech_Funcoes;
using SmartTech_Funcoes.DAO;
using SmartTech_Funcoes.Entidades;

namespace SmartTech.Formularios.Cadastros
{
    public partial class frmCadMunicipios : frmBaseCadastro
    {
        public frmCadMunicipios()
        {
            InitializeComponent();
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

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            frmConsultaMunicipio consulta = new frmConsultaMunicipio();           
            Util.AbreForm(this, consulta);
        }
    }
}
