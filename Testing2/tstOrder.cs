using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        string OrderName = "iPhone 13 pro";
        int OrderNumber = 1;
        DateTime DateOrdered = DateTime.Now;
        Double OrderPrice = 900.050;
        Double AmountPaid = 900.050;
        Boolean Dispatched = true;
        private object TestData;
        private object orderPrice;

        public object GetOrderPrice()
        {
            return orderPrice;
        }

        private void SetOrderPrice(object value)
        {
            orderPrice = value;
        }

        public object OrderDate { get; private set; }
        public object AnOrder { get; private set; }

        [TestMethod]
        public void InstancesOk()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void OrderNameOk()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "iPhone 13";
            AnOrder.OrderName = TestData;
        }
        [TestMethod]
        public void OrderNumberOk()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.OrderNumber = TestData;
            Assert.AreEqual(AnOrder.OrderNumber, TestData);
        }
        [TestMethod]
        public void OrderDateOk()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }
        [TestMethod]
        public void OrderPriceOk()
        {
            clsOrder AnOrder = new clsOrder();
            AnOrder.OrderPrice = (double)TestData;
            Assert.AreEqual(AnOrder.OrderPrice, TestData);
        }
        [TestMethod]
        public void AmountPaidOk()
        {
            clsOrder AnOrder = new clsOrder();
            AnOrder.OrderAmountOK = TestData;
            Assert.AreEqual(AnOrder.OrderAmountPaid, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderNumber = 1;
            Found = AnOrder.Find(OrderNumber);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderNumber()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = (int)TestData;
            Found = AnOrder.Find(OrderNumber);
            if (AnOrder.OrderNumber != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderNameFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 1;
            Found = AnOrder.Find(OrderNumber);
            if (AnOrder.OrderName != "iPhone 13")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 1;
            Found = AnOrder.Find(OrderNumber);
            if (AnOrder.OrderDate != Convert.ToDateTime(DateTime.Now))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderPriceFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 1;
            Found = AnOrder.Find(OrderNumber);
            if (AnOrder.OrderPice != 900.050)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAmountPaidFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 1;
            Found = AnOrder.Find(OrderNumber);
            if (AnOrder.AmountPaid != 900.050)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DispatchedFound()
        {

            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 1;
            Found = AnOrder.Find(OrderNumber);
            if (AnOrder.Dispatched != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "";
            Error = AnOrder.Valid(OrderName, OrderDate, GetOrderPrice(), AmountPaid);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "z";
            Error = AnOrder.Valid(OrderName, OrderDate, GetOrderPrice(), AmountPaid);
            Assert.AreEqual(Error, "");
        }
    

        [TestMethod]
        public void OrderNameMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "zz";
            Error = AnOrder.Valid(OrderName, OrderDate, GetOrderPrice(), AmountPaid);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "";
            OrderName = OrderName.PadRight(99, 'z');
            Error = AnOrder.Valid(OrderName, OrderDate, GetOrderPrice(), AmountPaid);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "";
            OrderName = OrderName.PadRight(100, 'z');
            Error = AnOrder.Valid(OrderName, OrderDate, GetOrderPrice(), AmountPaid);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "";
            OrderName = OrderName.PadRight(101, 'z');
            Error = AnOrder.Valid(OrderName, OrderDate, GetOrderPrice(), AmountPaid);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "";
            OrderName = OrderName.PadRight(50, 'z');
            Error = AnOrder.Valid(OrderName, OrderDate, GetOrderPrice(), AmountPaid);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMaxExtreme()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "";
            OrderName = OrderName.PadRight(2000, 'z');
            Error = AnOrder.Valid(OrderName, OrderDate, GetOrderPrice(), AmountPaid);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-500);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderName, OrderDate, GetOrderPrice(), AmountPaid);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderName, OrderDate, GetOrderPrice(), AmountPaid);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderName, OrderDate, GetOrderPrice(), AmountPaid);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderName, OrderDate, GetOrderPrice(), AmountPaid);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(+500);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderName, OrderDate, GetOrderPrice(), AmountPaid);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderDate = "This is not a date.";
            Error = AnOrder.Valid(OrderName, OrderDate, GetOrderPrice(), AmountPaid);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public double OrderPriceExtremeMin()
        {
                clsOrder clsOrder = new clsOrder();
                string Error = "";
                double OrderPrice = -10000;
            Error = AnOrder.valid(OrderName,
                                 OrderDate,
                                 OrderPrice,
                                 AmountPaid);
                Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPricemMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double OrderPrice = -0.01;
            Error = AnOrder.valid(OrderName, OrderDate, OrderPrice, AmountPaid);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderPriceMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double OrderPrice = 0.00;
            Error = AnOrder.valid(OrderName, OrderDate, OrderPrice, AmountPaid);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderPricePlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double OrderPrice = 0.01;
            Error = AnOrder.valid(OrderName, OrderDate, OrderPrice, AmountPaid);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderPriceMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double OrderPrice = 10000;
            Error = AnOrder.valid(OrderName, OrderDate, OrderPrice, AmountPaid);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AmountPaidMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double AmountPaid = -0.01;
            Error = AnOrder.valid(OrderName, OrderDate, GetOrderPrice(), AmountPaid);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AmountPaidMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double AmountPaid = 0.00;
            Error = AnOrder.valid(OrderName, OrderDate, GetOrderPrice(), AmountPaid);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AmountPaidMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double AmountPaid = 0.01;
            Error = AnOrder.valid(OrderName, OrderDate, GetOrderPrice(), AmountPaid);
            Assert.AreEqual(Error, "");
        }




    }
}












