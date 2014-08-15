using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BCM.WebFormsApplication.Checkout
{
    using BCM.WebFormsApplication.BLL;

    public partial class CheckoutStart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NVPAPICaller payPalCaller = new NVPAPICaller();
            string retMsg = "";
            string token = "";

            if (Session["payment_amt"] != null)
            {
                //string amt = Session["payment_amt"].ToString();
                decimal amt;
                if (!Decimal.TryParse(Session["payment_amt"].ToString(), out amt))
                    amt = 0.0m;

                bool ret = payPalCaller.ShortcutExpressCheckout(amt, ref token, ref retMsg);
                if (ret)
                {
                    Session["token"] = token;
                    Response.Redirect(retMsg);
                }
                else
                {
                    Response.Redirect("CheckoutError.aspx?" + retMsg);
                }
            }
            else
            {
                Response.Redirect("CheckoutError.aspx?ErrorCode=AmtMissing");
            }
        }
    }
}