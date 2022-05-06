using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    private object txtOrderDate;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        string OrderName = txtOrderName.Text;
        string OrderDate = txtOrderDate.Text;
        double OrderPrice = txtOrderPrice.Text;
        double OrderAmount = txtOrderAmount.Text;
        string Error = "";
        Error = AnOrder.Valid(OrderName, OrderDate, OrderPrice, OrderAmount);
        if (Error == "")
        {
            AnOrder.OrderName = OrderName;
            AnOrder.OrderDate = OrderDate;
            AnOrder.OrderPrice = OrderPrice;
            AnOrder.OrderAmount = OrderAmount;
            Session["AnOrder"] = AnOrder;
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void txtOrderDate_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderNumber;
        Boolean Found = false;
        OrderNumber = Convert.ToInt32(txtOrderNumber.Text);
        Found = AnOrder.Find(OrderNumber);
        if (Found == true)
        {
            txtOrderName.Text = AnOrder.OrderName;
            txtOrderDate.Text = AnOrder.OrderDate;
            txtOrderPrice.Text = AnOrder.OrderPrice;
            txtOrderAmount.Text = AnOrder.OrderAmount;
        }
    }
}