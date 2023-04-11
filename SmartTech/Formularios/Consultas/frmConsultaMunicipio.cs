using SmartTech.Formularios.Base;
using SmartTech_Funcoes;
using SmartTech_Funcoes.DAO;
using SmartTech_Funcoes.Entidades;
using System;
using System.Collections;
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
    public partial class frmConsultaMunicipio : frmBaseConsulta
    {
        public Util.DelegateRetornoConsulta<Municipio> SetRetornoConsultaCallback;
        private IList<Municipio> lista;
        public frmConsultaMunicipio()
        {
            InitializeComponent();
            lblTituloFormulario.Text = "Consulta Município";
        }

        private void RetornoConsulta(Municipio entidade)
        {
            SetRetornoConsultaCallback(entidade);
        }
        public override bool Func_PegaRegistroSelecionado()
        {
            try
            {

                Municipio ent = new Municipio();
                int? codigo = dgvConsulta.CurrentRow.Cells["Codigo"].Value.ToString().GetToIntExt();
                ent = lista.Where(m => m.Codigo == codigo).FirstOrDefault();

                RetornoConsulta(ent); //aciona metodo responsavel por enviar retorno para requerente.
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro");
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
                dgvConsulta.DataSource = lista.Where(m => m.Nome.ToLower().Contains(textoConsulta)).ToList();
            }
            return base.Func_TextChanged();
        }
        private void frmConsultaMunicipio_Load(object sender, EventArgs e)
        {
            // Crie uma instância da classe MunicipioDAO
            MunicipioDAO dao = new MunicipioDAO();

            // Obtenha uma lista de todos os municípios
            lista = dao.ObterTodos();
            toolStripRegistros.Text = lista.Count().ToString();


            // Atribua a lista de municípios ao DataSource do DataGridView
            dgvConsulta.DataSource = lista;

            // Defina as colunas do DataGridView para exibir as propriedades Nome e Estado da classe Municipio
            dgvConsulta.Columns["Codigo"].HeaderText = "Codigo";
            dgvConsulta.Columns["Nome"].HeaderText = "Nome do Município";
            dgvConsulta.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvConsulta.Columns["Estado"].HeaderText = "Estado";


        }
    }
}
