using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //prviate data member for the list
        List<clsCustomer> sCustomerList = new List<clsCustomer>();
        //prviate data memeber for thiscustomer
        clsCustomer sThisCustomer = new clsCustomer();
        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            sCustomerList = new List<clsCustomer>();
            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.IsOver18 = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsOver18"]);
                ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                ACustomer.CustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDOB"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                sCustomerList.Add(ACustomer);
                Index++;
            }

        }
        public List<clsCustomer> CustomerList
        {
            get
            {
                return sCustomerList;
            }
            set
            {
                sCustomerList = value;
            }
        }

        public int Count
        {
            get
            {
                return sCustomerList.Count;
            }
            set { }///////
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                return sThisCustomer;
            }
            set
            {
                sThisCustomer = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerName", sThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", sThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerDOB", sThisCustomer.CustomerDOB);
            DB.AddParameter("@CustomerAddress", sThisCustomer.CustomerAddress);
            DB.AddParameter("@IsOver18", sThisCustomer.IsOver18);
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", sThisCustomer.CustomerID);
            DB.Execute("sproc_tblCustomer_Delete");

        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", sThisCustomer.CustomerID);
            DB.AddParameter("@CustomerName", sThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", sThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerDOB", sThisCustomer.CustomerDOB);
            DB.AddParameter("@CustomerAddress", sThisCustomer.CustomerAddress);
            DB.AddParameter("@IsOver18", sThisCustomer.IsOver18);
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void ReportByAddress(string Address)
        {
            clsDataConnection DB = new clsDataConnection();         
            DB.AddParameter("@CustomerAddress", Address);
            DB.Execute("sproc_tblCustomer_FilterByCustomerAddress");
            PopulateArray(DB);
        }

    }
}
