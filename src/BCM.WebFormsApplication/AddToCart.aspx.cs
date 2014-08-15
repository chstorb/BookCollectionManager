using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BCM.WebFormsApplication
{
    using BCM.WebFormsApplication.BLL;
    using System.Diagnostics;

    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["bookID"];
            int bookID;
            if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out bookID))
            {
                using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
                {
                    usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }
            }
            else
            {
                Debug.Fail("ERROR : We should never get to AddToCart.aspx without a bookID.");
                throw new Exception("ERROR : It is illegal to load AddToCart.aspx without setting a bookID.");
            }
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}