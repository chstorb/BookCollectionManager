using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BCM.WebFormsApplication.Checkout
{
    using BCM.Model;
    using BCM.WebFormsApplication.Logic;

    public partial class CheckoutComplete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Verify user has completed the checkout process.
                if ((string)Session["userCheckoutCompleted"] != "true")
                {
                    Session["userCheckoutCompleted"] = string.Empty;
                    Response.Redirect("CheckoutError.aspx?" + "Desc=Unvalidated%20Checkout.");
                }

                NVPAPICaller payPalCaller = new NVPAPICaller();

                string retMsg = "";
                string token = "";
                string finalPaymentAmount = "";
                string PayerID = "";
                NVPCodec decoder = new NVPCodec();

                token = Session["token"].ToString();
                PayerID = Session["payerId"].ToString();
                finalPaymentAmount = Session["payment_amt"].ToString();

                bool ret = payPalCaller.DoCheckoutPayment(finalPaymentAmount, token, PayerID, ref decoder, ref retMsg);
                if (ret)
                {
                    // Retrieve PayPal confirmation value.
                    string PaymentConfirmation = decoder["PAYMENTINFO_0_TRANSACTIONID"].ToString();
                    TransactionId.Text = PaymentConfirmation;


                    BCM.DAL.ApplicationDbContext _db = new BCM.DAL.ApplicationDbContext();
                    // Get the current order id.
                    int currentOrderId = -1;
                    if (((string)Session["currentOrderId"]) != string.Empty)
                    {
                        currentOrderId = Convert.ToInt32(Session["currentOrderID"]);
                    }
                    Order myCurrentOrder;
                    if (currentOrderId >= 0)
                    {
                        // Get the order based on order id.
                        myCurrentOrder = _db.Orders.Single(o => o.ID == currentOrderId);
                        // Update the order to reflect payment has been completed.
                        myCurrentOrder.PaymentTransactionId = PaymentConfirmation;
                        // Save to DB.
                        _db.SaveChanges();
                    }

                    // Clear shopping cart.
                    using (BCM.WebFormsApplication.Logic.ShoppingCartActions usersShoppingCart =
                        new BCM.WebFormsApplication.Logic.ShoppingCartActions())
                    {
                        usersShoppingCart.EmptyCart();
                    }

                    // Clear order id.
                    Session["currentOrderId"] = string.Empty;
                }
                else
                {
                    Response.Redirect("CheckoutError.aspx?" + retMsg);
                }
            }
        }

        protected void Continue_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}