using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Forms.Extensions
{
    using System.ComponentModel;
    using System.Windows.Forms;

    /// <summary>
    /// NumericTextBox class
    /// </summary>
    public class NumericTextBox : TextBox
    {
        #region Event Handler

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Constants.Backspace)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        #endregion Event Handler

    }
}
