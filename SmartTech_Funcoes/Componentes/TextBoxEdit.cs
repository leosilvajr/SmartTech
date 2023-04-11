using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTech_Funcoes.Componentes
{
    public class TextBoxEdit : TextBox
    {
        public TextBoxEdit()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
