using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtCustomerEmail_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        // you are missing one i think its the ID
        string CustomerName = txtCustomerName.Text;
        string CustomerDOB = txtCustomerDOB.Text;
        string CustomerAddress = txtCustomerAddress.Text;
        string CustomerEmail = txtCustomerEmail.Text;
        string Error = "";
        Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
        if (Error == "")
        {
            ACustomer.CustomerName = CustomerName;
            ACustomer.CustomerDOB = Convert.ToDateTime(CustomerDOB);
            ACustomer.CustomerAddress = CustomerAddress;
            ACustomer.CustomerEmail = CustomerEmail;
           Session["ACustomer"] = ACustomer;
           Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Found = ACustomer.Find(CustomerID);
        if(Found == true)
        {
            txtCustomerName.Text = ACustomer.CustomerName;
            txtCustomerDOB.Text = ACustomer.CustomerDOB.ToString();
            txtCustomerAddress.Text = ACustomer.CustomerAddress;
            txtCustomerEmail.Text = ACustomer.CustomerEmail;
        }

    }
}