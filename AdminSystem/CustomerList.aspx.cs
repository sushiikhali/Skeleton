using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    { // if this is the first time the page has been displayed 
        if(IsPostBack == false)
        {
            //update the list box 
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //creating n instance of the Customer Collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //setting the data source to be list of customers in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //setting the name of the primary key 
        lstCustomerList.DataValueField = "CustomerID";
        //seting the data field( customers ID) to be displayed in the collection list
        lstCustomerList.DataTextField = "CustomerID";
        //binding the addresses to the list box. 
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //storing -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirecting to the data entry page 
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        ///variable to store the primary key value of the record to be edited.
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the dataentry page. 
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else // if not record is selected, then display this message 
        {
            lblError.Text = "Please Select a record to edit from the Customer List.";
        }
    }



    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be edited 
        Int32 CustomerID;
        //if a record has been selected from the list
        if(lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store data into session object 
            Session["CustomerID"] = CustomerID;
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }




    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the CustomerCollection
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByAddress(txtAddress.Text);
        lstCustomerList.DataSource = Customers.CustomerList;
        //setting name of primary key
        lstCustomerList.DataValueField = "CustomerID";
        //setting name of field to display 
        lstCustomerList.DataTextField = "CustomerAddress";
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create instance of Customer Collection 
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByAddress("");
        //clear any existing filter to tidy up the interface
        txtAddress.Text = "";
        lstCustomerList.DataSource = Customers.CustomerList;
        //setting name of primary key 
        lstCustomerList.DataValueField = "CustomerID";
        //setting name of the field to display
        lstCustomerList.DataTextField = "CustomerAddress";
        //bind data to list
        lstCustomerList.DataBind();
    }
}