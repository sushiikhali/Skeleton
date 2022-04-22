using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data logs
        private Int32 sCustomerID;
        private string sCustomerName;
        private Boolean sIsOver18;
        private DateTime sCustomerDOB;
        private string sCustomerAddress;
        private string sCustomerEmail;


        //public data logs
        public bool IsOver18
        {
            get
            {
                return sIsOver18;
            }
            set
            {
                sIsOver18 = value;
            }
        }
        public string CustomerName
        {
            get
            {
                return sCustomerName;
            }
            set
            {
                sCustomerName = value;
            }
        }
        public int CustomerID
        {
            get
            {
                return sCustomerID;
            }
            set
            {
                sCustomerID = value;
            }
        }
        public DateTime CustomerDOB
        {
            get
            {
                return sCustomerDOB;
            }
            set
            {
                sCustomerDOB = value;
            }
        }

        public string CustomerAddress
        {
            get
            {
                return sCustomerAddress;
            }
            set
            {
                sCustomerAddress = value;
            }
        }

        public string CustomerEmail
        {
            get
            {
                return sCustomerEmail;
            }
            set
            {
                sCustomerEmail = value;
            }
        }

        public string Valid(string nName)
        {
            if (nName.Length < 1)
            {
                return "Description cannot be blank";
            }
            if (nName.Length > 50)
            {
                return "Description cannot be more than 50 characters";
            }
            else
            {
                return "";
            }

        }

        public bool Find(int CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            if (DB.Count == 1)
            {
                sCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                sCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                sCustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB"]);
                sCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                sCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                sIsOver18 = Convert.ToBoolean(DB.DataTable.Rows[0]["IsOver18"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string customerName, DateTime customerDOB, string customerAddress, string customerEmail)
        {
            string Error = "";
            DateTime DateTemp;
            if (customerName.Length == 0)
            {
                Error = Error + "The name entered should not be blank ";
            }
            if (customerName.Length > 50)
            {
                Error = Error + "The name entered should not exceed 50 characters";
            }
            try
            {
                DateTemp = Convert.ToDateTime(customerDOB);
                if (DateTemp > DateTime.Now.Date.AddYears(-18).AddDays(1))
                {
                    Error = Error + "You should be atleast 18 years of age";
                }
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    Error = Error + "You should be under 100 years of age";
                }
            }

            catch
            {
                Error = Error + "Please enter a valid date ";
            }

            if (customerAddress.Length == 0)
            {
                Error += "Customer Address should not be empty";
            }
            if (customerAddress.Length > 50)
            {
                Error = Error + "Customer Address should not exceed 50 characters";
            }
            if (customerEmail.Length == 0)
            {
                Error = Error + "Customer Email should not be empty";
            }
            if (customerEmail.Length > 50)
            {
                Error = Error + "Customer Email should not exceed 50 characters";
            }

            return Error;

        }

    }
}