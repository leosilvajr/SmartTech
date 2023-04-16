
using SmartTech_Funcoes.Componentes;
using SmartTech_Funcoes.Entidades;
using System.ComponentModel;
using System.Reflection;

namespace SmartTech_Funcoes
{
    public static class MetodosExtensao
    {
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

        public static string GetTextSemMascara(this MaskedTextBoxEdit ctrl)
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

        public static void PreencheComboEstadosBrasil(this ComboBoxEdit obj)
        {
            IList<ItensComboBoxEntidade> lista = new List<ItensComboBoxEntidade>
              {
                new ItensComboBoxEntidade {Value = 11, Descricao = "RO"},
                new ItensComboBoxEntidade {Value = 12, Descricao = "AC"},
                new ItensComboBoxEntidade {Value = 13, Descricao = "AM"},
                new ItensComboBoxEntidade {Value = 14, Descricao = "RR"},
                new ItensComboBoxEntidade {Value = 15, Descricao = "PA"},
                new ItensComboBoxEntidade {Value = 16, Descricao = "AP"},
                new ItensComboBoxEntidade {Value = 17, Descricao = "TO"},
                new ItensComboBoxEntidade {Value = 21, Descricao = "MA"},
                new ItensComboBoxEntidade {Value = 22, Descricao = "PI"},
                new ItensComboBoxEntidade {Value = 23, Descricao = "CE"},
                new ItensComboBoxEntidade {Value = 24, Descricao = "RN"},
                new ItensComboBoxEntidade {Value = 25, Descricao = "PB"},
                new ItensComboBoxEntidade {Value = 26, Descricao = "PE"},
                new ItensComboBoxEntidade {Value = 27, Descricao = "AL"},
                new ItensComboBoxEntidade {Value = 28, Descricao = "SE"},
                new ItensComboBoxEntidade {Value = 29, Descricao = "BA"},
                new ItensComboBoxEntidade {Value = 31, Descricao = "MG"},
                new ItensComboBoxEntidade {Value = 32, Descricao = "ES"},
                new ItensComboBoxEntidade {Value = 33, Descricao = "RJ"},
                new ItensComboBoxEntidade {Value = 35, Descricao = "SP"},
                new ItensComboBoxEntidade {Value = 41, Descricao = "PR"},
                new ItensComboBoxEntidade {Value = 42, Descricao = "SC"},
                new ItensComboBoxEntidade {Value = 43, Descricao = "RS"},
                new ItensComboBoxEntidade {Value = 50, Descricao = "MS"},
                new ItensComboBoxEntidade {Value = 51, Descricao = "MT"},
                new ItensComboBoxEntidade {Value = 52, Descricao = "GO"},
                new ItensComboBoxEntidade {Value = 53, Descricao = "DF"},
              };

            obj.DataSource = lista;
        }
    }
}
