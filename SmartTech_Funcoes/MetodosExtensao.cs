
using System.ComponentModel;
using System.Reflection;

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

        /// <summary>
        /// Retorna string com o valor de um objeto 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToStringExt(this object obj)
        {
            string valor = Convert.ToString(obj);
            return valor;
        }

        /// <summary>
        /// retorna a quantidade de caracteres
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int LengthExt(this string value)
        {
            string valor = Convert.ToString(value) ?? "";
            return valor.ToString().Length;
        }

        /// <summary>
        /// Metodo de Extensão:  trata valor de um objeto e retorna um char
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static char GetToChartExt(this string value)
        {
            char.TryParse(value, out char result);
            return result;
        }

        /// <summary>
        /// Metodo de Extensão:  trata valor de um objeto e retorna um short
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static short GetToShortExt(this string value)
        {
            short.TryParse(value, out short result);
            return result;
        }

        /*
        /// <summary>
        /// Metodo de Extensão:  trata valor de um objeto e retorna um int
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int? GetToIntExt(this string value)
        {
          int.TryParse(value, out int result);
          return result;
        }
        */

        /// <summary>
        /// Metodo de Extensão:  trata valor de um objeto e retorna um int?, permitindo retorno de valor Nulo.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int? GetToIntExt(this string value)
        {
            int result;
            if (!string.IsNullOrEmpty(value))
            {
                int.TryParse(value, out result);
                return result;
            }
            else
                return null;
        }


        /// <summary>
        /// Metodo de Extensão:  trata valor de um objeto e retorna um long
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long? GetToLongExt(this string value)
        {
            long.TryParse(value, out long result);
            return result;
        }

        /// <summary>
        /// Metodo de Extensão:  trata valor de um objeto e retorna um DateTime
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime GetToDateTimeExt(this string value)
        {
            DateTime.TryParse(value, out DateTime result);
            return result;
        }

        /// <summary>
        /// Metodo de Extensão:  trata valor de um objeto e retorna um decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal GetToDecimalExt(this string value)
        {
            //aqui por enquando não uso opcao de devolver nulo, se acontecer alterar metodo
            decimal.TryParse(value, out decimal result);
            return result;

        }

        /// <summary>
        /// Metodo de Extensão:  devolve o valor decimal formatado em uma string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetToStringFormatadoExt(this string value, int numeroCasasDecimais = 2)
        {
            //aqui por enquando não uso opcao de devolver nulo, se acontecer alterar metodo
            decimal.TryParse(value, out decimal result);
            return result.ToString("N" + numeroCasasDecimais);

        }


        /// <summary>
        /// Metodo de Extensão: Retorna o valor do MaskedTextBoxEdit sem a mascara
        /// </summary>
        /// <param name="ctrl"></param>
        public static string GetTextSemMascara(this MaskedTextBox ctrl)
        {
            string valor = null;
            string newValue;
            if (!string.IsNullOrEmpty(ctrl.Mask))
            {
                ctrl.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                newValue = ctrl.Text;
                ctrl.TextMaskFormat = MaskFormat.IncludeLiterals;

            }
            else
                newValue = new string(ctrl.Text.Where(c => Char.IsLetterOrDigit(c)).ToArray());

            valor = newValue; //ctrl.Text;
            return valor;
        }

        /// <summary>
        /// Metodo Extensão : retorna apenas os numeros de uma string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetSoNumerosExt(this string value)
        {
            string newValue = new string(value.Where(c => Char.IsDigit(c)).ToArray());
            return newValue;
        }

        /// <summary>
        /// Metodo de Extensão: retorna o value do item selecionado de um comboBox
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>


        /// <summary>
        /// Metodo de extensão: preenche o Data Source do ComboBoxEdit com os estados do brasil
        /// </summary>
        /// <returns></returns>


 




        /// <summary>
        /// Metodo de Extensão: Devolve a Descrição de um determinado Enum
        /// </summary>
        /// <typeparam name="T">tipo generico</typeparam>
        /// <param name="value">enumerador que vamos localizar a descrição</param>
        /// <returns></returns>
        public static string GetValueDescriptionEnum<T>(this T value)
        {
            return
              value
                  .GetType()
                  .GetMember(value.ToString())
                  .FirstOrDefault()
                  ?.GetCustomAttribute<DescriptionAttribute>()
                  ?.Description
              ?? value.ToString();
        }

        public static void EnableTabExt(this TabControl page, bool enable)
        {
            if (page == null) return;
            foreach (Control ctl in page.Controls) ctl.Enabled = enable;
        }

    }
}
