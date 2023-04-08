using static System.Net.WebRequestMethods;
using System.Net.Http;
using System.Collections.Specialized;
using SmartTech_Funcoes;
using SmartTech.Formularios.Configuracoes;

namespace SmartTech
{
    public partial class frmPrincipal : Form
    {
        //Variaveis para o Toogle Panels
        private Boolean showPanelCadastro = false;
        private Boolean showPanelFinanceiro = false;
        private Boolean showPanelRelatorio = false;
        private Boolean showPanelUltilitarios = false;
        private Boolean showPanelConfiguracoes = false;

        //Variaveis para arrastar Panel Topo
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Variavel que adiciona Sombra no Form
        private const int CS_DROPSHADOW = 0x00020000;
        public frmPrincipal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MinimumSize = new Size(800, 600);
            tooglePanels();
            pnlSuperior.MouseDown += new MouseEventHandler(pnlSuperior_MouseDown);
            pnlSuperior.MouseMove += new MouseEventHandler(pnlSuperior_MouseMove);
            pnlSuperior.MouseUp += new MouseEventHandler(pnlSuperior_MouseUp);
            this.WindowState = FormWindowState.Normal;


        }

        //Propriedade que Adiciona Sombra no Formulario
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            showPanelCadastro = !showPanelCadastro;
            tooglePanels();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            showPanelFinanceiro = !showPanelFinanceiro;
            tooglePanels();
        }
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            showPanelRelatorio = !showPanelRelatorio;
            tooglePanels();
        }
        private void btnUltilitarios_Click(object sender, EventArgs e)
        {
            showPanelUltilitarios = !showPanelUltilitarios;
            tooglePanels();
        }
        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            showPanelConfiguracoes = !showPanelConfiguracoes;
            tooglePanels();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tooglePanels()
        {
            //Panel Cadastro
            if (showPanelCadastro)
            {
                panelCadastros.Height = 96;
            }
            else
            {
                panelCadastros.Height = 0;
            }

            //Panel Financeiro
            if (showPanelFinanceiro)
            {
                panelFinanceiro.Height = 64;
            }
            else
            {
                panelFinanceiro.Height = 0;
            }

            //Panel Relatorios
            if (showPanelRelatorio)
            {
                panelRelatorios.Height = 64;
            }
            else
            {
                panelRelatorios.Height = 0;
            }

            //Panel Ultilitarios 
            if (showPanelUltilitarios)
            {
                panelUltilitarios.Height = 64;
            }
            else
            {
                panelUltilitarios.Height = 0;
            }

            //Panel Configuracoes

            if (showPanelConfiguracoes)
            {
                panelConfiguracoes.Height = 64;
            }
            else
            {
                panelConfiguracoes.Height = 0;
            }
        }

        //Comando para Arrastar o Panel Topo
        private void pnlSuperior_MouseDown(object? sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        //Comando para Arrastar o Panel Topo
        private void pnlSuperior_MouseMove(object? sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        //Comando para Arrastar o Panel Topo
        private void pnlSuperior_MouseUp(object? sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Comando correto para maximizar e Minimizar o meu Formulario;
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                MaximumSize = Screen.FromHandle(Handle).WorkingArea.Size;
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBancoDados_Click(object sender, EventArgs e)
        {
            frmBancoDados banco = new frmBancoDados();
            Util.AbreForm(pnlBase, banco);
        }
    }
}