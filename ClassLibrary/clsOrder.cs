using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data logs 
        public string OrderName;
        private string dOrderName;
        private Int32 dOrderNumber;
        private DateTime dOrderDate;
        private Decimal dOrderPrice;
        private Decimal dOrderAmount;
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




        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public object OrderPrice { get; set; }
        public object OrderAmountOK { get; set; }
        public object OrderAmountPaid { get; set; }
        public double OrderPice { get; set; }
        public double AmountPaid { get; set; }
        

        public bool Find(int orderNumber)
        {
            throw new NotImplementedException();
        }
    }
}