using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        //Access to the shopping cart
        ShoppingCartInfo cart = (ShoppingCartInfo)Session["UserShoppingCart"];
        cart.DesiredCar = txtMake.Text;
        cart.DesiredCarColor = txtColor.Text;
        cart.DownPayment = float.Parse(txtDownPayment.Text);
        cart.IsLeasing = cbxLeasing.Checked;
        cart.DateOfPickUp = cldDeliveryDate.SelectedDate;
        //Need to set the cart back to the session.
        Session["UserShoppingCart"] = cart;

    }
}