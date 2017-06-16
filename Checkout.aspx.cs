using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Checkout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ShoppingCartInfo cart = (ShoppingCartInfo)Session["UserShoppingCart"];
        lblColor.Text = cart.DesiredCarColor;
        lblMake.Text = cart.DesiredCar;
        lblDownPayment.Text = cart.DownPayment.ToString();
        lblLeasing.Text = cart.IsLeasing.ToString();
        lblDeliveryDate.Text = cart.DateOfPickUp.ToShortDateString();

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        //Save this shopping cart into DB.
        //Clear it/remove it/or reinitialize it.
        Session["UserShoppingCart"] = new ShoppingCartInfo();
    }
}