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
        Decimal Price = 900.050;
        Decimal AmountPaid = 900.050;
        Boolean Dispatched = true;
        private object TestData;

        [TestMethod]
        public void InstancesOk()
        {
            clsOrder AOrder = new clsOrder();
            Assert.IsNotNull(AOrder);
        }
        [TestMethod]
        public void OrderNameOk()
        {
            clsOrder AOrder = new clsOrder();
            string TestData = "iPhone 13";
            AOrder.OrderName = TestData;
        }
        [TestMethod]
        public void OrderNumberOk()
        {
            clsOrder AOrder = new clsOrder();
            Int32 TestData = 1;
            AOrder.OrderNumber = TestData;
            Assert.AreEqual(AOrder.OrderNumber, TestData);
        }
        [TestMethod]
        public void OrderDateOk()
        {
            clsOrder AOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AOrder.OrderDate = TestData;
            Assert.AreEqual(AOrder.OrderDate, TestData);
        }
        [TestMethod]
        public void PriceOk()
        {
            clsOrder AOrder = new clsOrder();
            AOrder.OrderPrice = TestData;
            Assert.AreEqual(AOrder.OrderPrice, TestData);
        }
        [TestMethod]
        public void AmountPaidOk()
        {
            clsOrder AOrder = new clsOrder();
            AOrder.OrderAmountOK = TestData;
            Assert.AreEqual(AOrder.OrderAmountPaid, TestData);
        }

        [TestMethod]
        public void TestOrderNumber()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = TestData;
            Found = AOrder.Find(OrderNumber);
            if(AOrder.OrderNumber != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderNameFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 1;
            Found = AOrder.Find(OrderNumber);
            if (AOrder.OrderName != "iPhone 13")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 1;
            Found = AOrder.Find(OrderNumber);
            if (AOrder.OrderDate != Convert.ToDateTime(DateTime.Now))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderPriceFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 1;
            Found = AOrder.Find(OrderNumber);
            if (AOrder.OrderPice != 900.050)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAmountPaidFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 1;
            Found = AOrder.Find(OrderNumber);
            if (AOrder.AmountPaid != 900.050)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DispatchedFound()
        {

            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 1;
            Found = AOrder.Find(OrderNumber);
            if(AOrder.Dispatched != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        
    }
 }












