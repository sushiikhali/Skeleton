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
        ACustomer.CustomerName = txtCustomerName.Text;
        ACustomer.CustomerDOB = Convert.ToDateTime(txtCustomerDOB.Text);
        ACustomer.CustomerAddress = txtCustomerAddress.Text;
        ACustomer.CustomerEmail = txtCustomerEmail.Text;
        ACustomer.IsOver18 = chkIsOver18.Checked;



        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");

        
    }
}