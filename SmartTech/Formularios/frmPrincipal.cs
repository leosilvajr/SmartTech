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

        //Variaveis para manipular Função WndProc do Redisionamento.
        private int borderSize = 2; //borda
        private Size formSize; //Mantenha o tamanho do formulário quando ele for minimizado e restaurado. Já que o formulário é redimensionado porque leva em consideração o tamanho da barra de título e das bordas..
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

        private void AdjsutForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 8);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                    {
                        this.Padding = new Padding(borderSize);
                    }
                    break;
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Barra de Título Padrão - Janela de Snap
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimizar formulário (antes)
            const int SC_RESTORE = 0xF120; //Restaurar formulário (antes)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determina qual parte da janela corresponde a um ponto, permite redimensionar o formulário.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Representa a área do cliente da janela
            const int HTLEFT = 10;  //Borda esquerda de uma janela, permite redimensionar horizontalmente para a esquerda
            const int HTRIGHT = 11; //Borda direita de uma janela, permite redimensionar horizontalmente à direita
            const int HTTOP = 12;   //Borda horizontal superior de uma janela, permite redimensionar verticalmente para cima
            const int HTTOPLEFT = 13;//Canto superior esquerdo de uma borda de janela, permite redimensionar diagonalmente para a esquerda
            const int HTTOPRIGHT = 14;//Canto superior direito de uma borda de janela, permite redimensionar diagonalmente para a direita
            const int HTBOTTOM = 15; //Borda horizontal inferior de uma janela, permite redimensionar verticalmente para baixo
            const int HTBOTTOMLEFT = 16;//Canto inferior esquerdo de uma borda de janela, permite redimensionar diagonalmente para a esquerda
            const int HTBOTTOMRIGHT = 17;//Canto inferior direito de uma borda de janela, permite redimensionar diagonalmente para a direita
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //Se o windows m for WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Redimensione o formulário se estiver no estado normal
                {
                    if ((int)m.Result == HTCLIENT)//Se o resultado do m (ponteiro do mouse) estiver na área do cliente da janela
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Obtém as coordenadas do ponto da tela (coordenadas X e Y do ponteiro)                          
                        Point clientPoint = this.PointToClient(screenPoint); //Calcula a localização do ponto da tela em coordenadas do cliente                          
                        if (clientPoint.Y <= resizeAreaSize)//Se o ponteiro estiver no topo do formulário (dentro da área de redimensionamento - coordenada X)
                        {
                            if (clientPoint.X <= resizeAreaSize) //Se o ponteiro estiver na coordenada X=0 ou menor que a área de redimensionamento (X=10) em 
                                m.Result = (IntPtr)HTTOPLEFT; //Redimensionar diagonalmente para a esquerda
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//Se o ponteiro estiver na coordenada X=11 ou menor que a largura do formulário(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Redimensionar verticalmente para cima
                            else //Redimensionar diagonalmente para a direita
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //Se o ponteiro estiver dentro do formulário na coordenada Y (descontando o tamanho da área de redimensionamento)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Redimensionar horizontalmente para a esquerda
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Redimensionar horizontalmente para a direita
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Redimensionar diagonalmente para a esquerda

                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Redimensionar verticalmente para baixo

                                m.Result = (IntPtr)HTBOTTOM;
                            else //Redimensionar diagonalmente para a direito
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remova a borda e mantenha a janela de encaixe
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Mantenha o tamanho do formulário quando ele for minimizado e restaurado. Já que o formulário é redimensionado porque leva em consideração o tamanho da barra de título e das bordas.
            if (m.Msg == WM_SYSCOMMAND)
            {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
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

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            AdjsutForm();
        }
    }
}