using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTech_Funcoes.Componentes
{
    public class ComboBoxEdit : ComboBox
    {
        public ComboBoxEdit()
        {
 
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
