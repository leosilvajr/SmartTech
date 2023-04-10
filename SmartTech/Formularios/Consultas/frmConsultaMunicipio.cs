using SmartTech.Formularios.Base;
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
    public partial class frmConsultaMunicipio : frmBaseConsulta
    {

        public frmConsultaMunicipio()
        {
            InitializeComponent();
            lblTituloFormulario.Text = "Consulta Município";
        }

        private void frmConsultaMunicipio_Load(object sender, EventArgs e)
        {
            // Crie uma instância da classe MunicipioDAO
            MunicipioDAO dao = new MunicipioDAO();

            // Obtenha uma lista de todos os municípios
            List<Municipio> municipios = dao.ListarTodos();

            // Atribua a lista de municípios ao DataSource do DataGridView
            dgvConsulta.DataSource = municipios;

            // Defina as colunas do DataGridView para exibir as propriedades Nome e Estado da classe Municipio
            dgvConsulta.Columns["Nome"].HeaderText = "Nome do Município";
            dgvConsulta.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvConsulta.Columns["Estado"].HeaderText = "Estado";
            
        }
    }
}
