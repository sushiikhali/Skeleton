using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope 
    Int32 CustomerID;
    //event handler for the page load event 

    protected void Page_Load(object sender, EventArgs e)
    {
        //getting the number of customers to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if(IsPostBack == false)
        {
            //populate the list of Customers
        }
    }

    protected void txtCustomerEmail_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to main page
        Response.Redirect("Default.aspx");

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        int CustomerID = Convert.ToInt32(txtCustomerID.Text);
        string CustomerName = txtCustomerName.Text;
        string CustomerDOB = txtCustomerDOB.Text;
        string CustomerAddress = txtCustomerAddress.Text;
        string CustomerEmail = txtCustomerEmail.Text;
        string Error = "";
        Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
        if (Error == "")
        {


            ACustomer.CustomerID = (CustomerID);
            ACustomer.CustomerName = CustomerName;
            ACustomer.CustomerDOB = Convert.ToDateTime(CustomerDOB);
            ACustomer.CustomerAddress = CustomerAddress;
            ACustomer.CustomerEmail = CustomerEmail;
            ACustomer.IsOver18 = chkIsOver18.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if (CustomerID == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
            Response.Redirect("CustomerList.aspx");
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
        if (Found == true)
        {
            txtCustomerName.Text = ACustomer.CustomerName;
            txtCustomerDOB.Text = ACustomer.CustomerDOB.ToString();
            txtCustomerAddress.Text = ACustomer.CustomerAddress;
            txtCustomerEmail.Text = ACustomer.CustomerEmail;
        }
    }

        void DisplayCustomer()
        {
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            CustomerList.ThisCustomer.Find(CustomerID);
        //displaying data 
        txtCustomerID.Text = CustomerList.ThisCustomer.CustomerID.ToString();
            txtCustomerName.Text = CustomerList.ThisCustomer.CustomerName;
            txtCustomerDOB.Text = CustomerList.ThisCustomer.CustomerDOB.ToString();
            txtCustomerAddress.Text = CustomerList.ThisCustomer.CustomerAddress;
            txtCustomerEmail.Text = CustomerList.ThisCustomer.CustomerEmail;
            chkIsOver18.Checked = CustomerList.ThisCustomer.IsOver18;


        }
    }

