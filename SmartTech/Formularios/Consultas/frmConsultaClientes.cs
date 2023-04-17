using SmartTech.Formularios.Base;
using SmartTech_Funcoes;
using SmartTech_Funcoes.DAO;
using SmartTech_Funcoes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTech.Formularios.Consultas
{
    public partial class frmConsultaClientes : frmBaseConsulta
    {
        public Util.DelegateRetornoConsulta<Cliente> SetRetornoConsultaCallback;
        private IList<Cliente> lista;
        public frmConsultaClientes()
        {
            InitializeComponent();
            lblTituloFormulario.Text = "Consulta Cliente";
        }
        private void RetornoConsulta(Cliente entidade)
        {
            SetRetornoConsultaCallback(entidade);
        }

        public override bool Func_PegaRegistroSelecionado()
        {
            try
            {

                Cliente ent = new Cliente();
                int? codigo = dgvConsulta.CurrentRow.Cells["Codigo"].Value.ToString().GetToIntExt();
                ent = lista.Where(m => m.Codigo == codigo).FirstOrDefault();

                RetornoConsulta(ent); //aciona metodo responsavel por enviar retorno para requerente.
                return true;
            }
            catch (Exception ex)
            {

                Mensagem.MostraErro("Erro ao consultar cliente.");
                return false;
            }
        }
        public override bool Func_TextChanged()
        {
            string textoConsulta = txtConsulta.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(textoConsulta))
            {
                dgvConsulta.DataSource = lista;
            }
            else
            {
                dgvConsulta.DataSource = lista.Where(m => m.NomeRazaoSocial.ToLower().Contains(textoConsulta)).ToList();
            }
            return base.Func_TextChanged();
        }

        private void frmConsultaClientes_Load(object sender, EventArgs e)
        {
            // Crie uma instância da classe MunicipioDAO
            ClienteDAO dao = new ClienteDAO();

            // Obtenha uma lista de todos os municípios
            lista = dao.ObterTodos();
            toolStripRegistros.Text = lista.Count().ToString();


            // Atribua a lista de municípios ao DataSource do DataGridView
            dgvConsulta.DataSource = lista;

        }
    }
}
