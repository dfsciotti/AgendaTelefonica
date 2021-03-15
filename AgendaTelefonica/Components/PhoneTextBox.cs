using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgendaTelefonica.Components
{
    public partial class PhoneTextBox : TextBox
    {
        public bool isModified { get; set; }
        public PhoneTextBox()
        {
            isModified = false;
            this.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.MaxLength = 14;
            this.Width = 100;
            this.Height = 25;
            this.Text = string.Empty;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        protected override void OnValidated(EventArgs e)
        {
            this.Text = MascaraTelefone(this.Text);
            isModified = true;
            base.OnValidated(e);
        }

        protected override void OnClick(EventArgs e)
        {
            this.SelectAll();
            base.OnClick(e);
        }

        private string MascaraTelefone(string strNumero)
        {
            //só considera numeros para não ocorrer erros de conversão
            for (int i = 0; i < strNumero.Length; i++)
            {
                if(strNumero[i] != '0' && strNumero[i] != '1' && strNumero[i] != '2' && strNumero[i] != '3' &&
                    strNumero[i] != '4' && strNumero[i] != '5' && strNumero[i] != '6' && strNumero[i] != '7' && 
                    strNumero[i] != '8' && strNumero[i] != '9')
                {
                    strNumero.Replace(strNumero[i], ' ');
                }
            }

            if (!string.IsNullOrEmpty(strNumero))
            {
                string numero = strNumero.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ","");
                string strMascara = "{0:(00)0000-0000}";
                try
                {
                    long lngNumero = Convert.ToInt64(numero);
                    if (numero.Length == 11)
                        strMascara = "{0:(00)00000-0000}";
                    return string.Format(strMascara, lngNumero);
                }
                catch(Exception)
                {
                    return string.Empty;
                }                
            }
            return string.Empty;
        }
    }
}
