
namespace SmartTech_Funcoes
{
    public static class MetodosExtensao
    {
        public static void CentralizaForm(this Panel pnl, Form frm)
        {
            pnl.Controls.Add(frm);
            frm.Parent = pnl;
            frm.StartPosition = FormStartPosition.CenterParent;
            int x = (pnl.Width / 2) - (frm.Width / 2);
            int y = (pnl.Height / 2) - (frm.Height / 2);
            frm.Location = new Point(x, y);
        }
    }
}
