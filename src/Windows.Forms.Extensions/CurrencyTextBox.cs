using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Windows.Forms.Extensions
{
    using System.ComponentModel;
    using System.Globalization;
    using System.Reflection;
    using System.Windows.Forms;

    /// <summary>
    /// CurrencyTextBox class
    /// </summary>
    public class CurrencyTextBox : TextBox
    {
        private bool _isSubscribed = false;

        public CurrencyTextBox()
            : base()
        {
            this.DataBindings.CollectionChanged += new CollectionChangeEventHandler(dataBindings_CollectionChanged);
        }

        #region Event Handler

        private void dataBindings_CollectionChanged(object sender, CollectionChangeEventArgs e)
        {
            if (_isSubscribed)
            {
                Binding binding = this.DataBindings["Text"];
                if (binding != null)
                {
                    binding.Format -= new ConvertEventHandler(this.Format);
                    binding.Parse -= new ConvertEventHandler(this.Parse);
                }
                _isSubscribed = false;
            }
            else 
            {
                Binding binding = this.DataBindings["Text"];
                if (binding != null)
                {
                    binding.Format += new ConvertEventHandler(this.Format);
                    binding.Parse += new ConvertEventHandler(this.Parse);
                }
                _isSubscribed = true;
            }
        }

        private void Format(object sender, ConvertEventArgs e)
        {
            try
            {
                if (e.Value == null)
                {
                    e.Value = String.Empty;
                }
                else
                {
                    e.Value = Convert.ToDecimal(e.Value).ToString("C");

                }
            }
            catch (Exception)
            {
                e.Value = String.Empty;
            }
        }

        private void Parse(object sender, ConvertEventArgs e)
        {
            try
            {
                if (e.Value == null)
                {
                    e.Value = String.Empty;
                }
                else
                {
                    e.Value = Decimal.Parse(e.Value.ToString(), NumberStyles.Currency);
                    
                    Binding binding = this.DataBindings["Text"];
                    if (binding != null)
                    {
                        CurrencyManager dataManager = this.BindingContext[binding.DataSource] as CurrencyManager;
                        PropertyDescriptor pd = dataManager.GetItemProperties()[binding.BindingMemberInfo.BindingMember];
                        pd.SetValue(((BindingSource)binding.DataSource).Current, e.Value);
                    }
                }
            }
            catch (Exception)
            {
                e.Value = String.Empty;
            }
        }

        #endregion Event Handler
    }
}
