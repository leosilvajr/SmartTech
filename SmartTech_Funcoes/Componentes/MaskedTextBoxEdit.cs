using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTech_Funcoes.Componentes
{
    public class MaskedTextBoxEdit : MaskedTextBox
    {
        public MaskedTextBoxEdit()
        {
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

        }
        private bool _isCnpj = false;
        private bool _isCelular = false;
        private bool _isTelefone = false;
        private bool _isCEP = false;
        private bool _isCPF = false;

        [Category("Custom")]
        [Description("Indicates whether the MaskedTextBox should be configured for CNPJ format")]
        [DefaultValue(false)]
        public bool CNPJ
        {
            get { return _isCnpj; }
            set
            {
                _isCnpj = value;
                if (_isCnpj)
                {
                    this.Mask = "00,000,000/0000-00";
                }
                else
                {
                    // Here you can set the Mask property to a default value for non-CNPJ fields
                    // For example: this.Mask = "00000-000";
                }
            }
        }

        [Category("Custom")]
        [Description("Indicates whether the MaskedTextBox should be configured for CNPJ format")]
        [DefaultValue(false)]
        public bool CELULAR
        {
            get { return _isCelular; }
            set
            {
                _isCelular = value;
                if (_isCelular)
                {
                    this.Mask = "(00)00000-0000";
                }
                else
                {
                    // Here you can set the Mask property to a default value for non-CNPJ fields
                    // For example: this.Mask = "00000-000";
                }
            }
        }

        [Category("Custom")]
        [Description("Indicates whether the MaskedTextBox should be configured for CNPJ format")]
        [DefaultValue(false)]
        public bool TELEFONE
        {
            get { return _isTelefone; }
            set
            {
                _isTelefone = value;
                if (_isTelefone)
                {
                    this.Mask = "(00)0000-0000";
                }
                else
                {
                    // Here you can set the Mask property to a default value for non-CNPJ fields
                    // For example: this.Mask = "00000-000";
                }
            }
        }

        [Category("Custom")]
        [Description("Indicates whether the MaskedTextBox should be configured for CNPJ format")]
        [DefaultValue(false)]
        public bool CEP
        {
            get { return _isCEP; }
            set
            {
                _isCEP = value;
                if (_isCEP)
                {
                    this.Mask = "00000-000";
                }
                else
                {
                    // Here you can set the Mask property to a default value for non-CNPJ fields
                    // For example: this.Mask = "00000-000";
                }
            }
        }

        [Category("Custom")]
        [Description("Indicates whether the MaskedTextBox should be configured for CNPJ format")]
        [DefaultValue(false)]
        public bool CPF
        {
            get { return _isCPF; }
            set
            {
                _isCPF = value;
                if (_isCPF)
                {
                    this.Mask = "000,000,000-00";
                }
                else
                {
                    // Here you can set the Mask property to a default value for non-CNPJ fields
                    // For example: this.Mask = "00000-000";
                }
            }
        }

    }
}
