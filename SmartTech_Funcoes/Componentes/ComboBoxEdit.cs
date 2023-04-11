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
            //Mostra apenas 5

            this.DropDownHeight = ItemHeight * 5;
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
