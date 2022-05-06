using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data logs 
        private string dOrderName;
        private Int32 dOrderNumber;
        private DateTime dOrderDate;
        private Double dOrderPrice;
        private Double dOrderAmount;
        private Boolean dDispatched;

        //public data log 

        public bool Dispatched
        {
            get
            {
                return dDispatched;
            }

            set
            {
                dDispatched = value;
            }

        }

        public string OrderName
        {
            get
            {
                return dOrderName;
            }
            set
            {
                dOrderName = value;
            }
        }


        public int OrderNumber
        {
            get
            {
                return dOrderNumber;
            }
            set
            {
                dOrderNumber = value;
            }
        }


        public DateTime OrderDate
        {
            get
            {
                return dOrderDate;
            }
            set
            {
                dOrderDate = value;
            }
        }

        public double OrderPrice
        {
            get
            {
                return dOrderPrice;
            }
            set
            {
                dOrderPrice = value;
            }
        }

        public double OrderAmount
        {
            get
            {
                return dOrderAmount;
            }
            set
            {
                dOrderAmount = value;
            }
        }






        public object OrderAmountOK { get; set; }
        public object OrderAmountPaid { get; set; }
        public double OrderPice { get; set; }
        public double AmountPaid { get; set; }

        public string Valid(string mName)
        {
           if (mName.Length < 1)
            {
                return "Description cannot be left blank";
            }
            if (mName.Length > 50)
            {
                return "Descritpion cannot be more than 100 charecters long";
            }
            
        }



        public bool Find(int orderNumber)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNumber", OrderNumber);
            DB.Execute("sproc_tblOrder_FilterByOrderNumber");
            if(DB.Count ==1)
            {
                dOrderNumber = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNumber"]);
                dOrderName = Convert.ToString(DB.DataTable.Rows[0]["OrderName"]);
                dOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                dOrderPrice = Convert.ToDouble(DB.DataTable.Rows[0]["OrderPrice"]);
                dOrderAmount = Convert.ToDouble(DB.DataTable.Rows[0]["OrderAmount"]);
                dDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["Dispatched"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string orderName, object orderDate, object orderPrice, decimal amountPaid)
        {
            throw new NotImplementedException();
        }

        public string Valid(string orderName, string orderDate, object orderPrice, decimal amountPaid)
        {
            throw new NotImplementedException();
        }

        public decimal valid(string orderName, object orderDate, decimal orderPrice, decimal amountPaid)
        {
            throw new NotImplementedException();
        }

        public string Valid(string orderName, object orderDate, object orderPrice, double amountPaid)
        {
            throw new NotImplementedException();
        }

        public string valid(string orderName, object orderDate, double orderPrice, double amountPaid)
        {
            throw new NotImplementedException();
        }

        public string Valid(string orderName, string orderDate, Action orderPrice, double amountPaid)
        {
            throw new NotImplementedException();
        }

        public string valid(string orderName, object orderDate, object orderPrice, double amountPaid)
        {
            throw new NotImplementedException();
        }

        public string Valid(string OrderName, string OrderDate, string DateOrdered, string OrderPrice, string AmountPaid)
        {
            string Error = "";
            DateTime DateTemp;
            if (OrderName.Length ==0)
            {
                Error = Error + "The order name should't be blank ";
            }
            if (OrderName.Length > 100)
            {
                Error = Error + "The order name should't exceed 100 charecters";
            }
            try
            {
                DateTemp = Convert.ToDateTime(OrderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past";
                }
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future";
                }
            }

            catch
            {
                Error = Error + "Please enter a Price";
            }
            if (OrderPrice.Convert.ToInt32(10000) == 0)
            {
                Error += "Order price shouldn't be blank";
            }
            if (OrderPrice = 10000)
            {
                Error = Error + "Order price should not exceed 10.000.000 charecter";
            }
            if (AmountPaid = 10000)
            {
                Error = Error + "Amount Paid should not exceed 10.000.000";
            }




        }






    }
}