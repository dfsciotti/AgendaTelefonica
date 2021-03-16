using MetroFramework.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace AgendaTelefonica.Components
{
    public partial class NumericTextBox : TextBox
    {
        public NumericTextBox()
        {
            this.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.MaxLength = 16;
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
    }
}
