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
                municipioExistente.Estado = txtEstado.Text;

                dao.Atualizar(municipioExistente);

                MessageBox.Show("Município atualizado com sucesso!");
                MontaTela();

            }
            else
            {
                // Cria um novo registro
                Municipio novoMunicipio = new Municipio();
                novoMunicipio.Nome = txtNome.Text;
                novoMunicipio.Estado = txtEstado.Text;

                dao.Inserir(novoMunicipio);

                MessageBox.Show("Município salvo com sucesso!");
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
