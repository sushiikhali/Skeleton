using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//v00egd00001l.lec-admin.dmu.ac.uk
namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        string CustomerName = "Alex Wong";
        int CustomerID = 1;
        DateTime CustomerDOB = DateTime.Now;
        string CustomerAddress = "159 High St Liverpool EN5 4AA";
        string CustomerEmail = "ThisisAlex@outlook.com";
        bool IsOver18 = true;

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer Acustomer = new clsCustomer();
            Assert.IsNotNull(Acustomer);
        }
        [TestMethod]
        public void NameOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Alex Wong";
            ACustomer.CustomerName = TestData;
            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }
        [TestMethod]
        public void CustomerIDOK()
        {

            clsCustomer ACustomer = new clsCustomer();
            Int32 TestData = 1;
            ACustomer.CustomerID = TestData;
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }
        [TestMethod]
        public void AgeOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.IsOver18 = TestData;
            Assert.AreEqual(ACustomer.IsOver18, TestData);
        }
        [TestMethod]
        public void CustomerDOBOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.CustomerDOB = TestData;
            Assert.AreEqual(ACustomer.CustomerDOB, TestData);
        }
        [TestMethod]
        public void CustomerAddressOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "159 High St Liverpool EN5 4AA";
            ACustomer.CustomerAddress = TestData;
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }
        [TestMethod]
        public void CustomerEmailOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "ThisisAlex@outlook.com";
            ACustomer.CustomerEmail = TestData;
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if(ACustomer.CustomerID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerName != "Alex Wong")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerDOBFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerDOB != Convert.ToDateTime("06/09/2001"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerAddress != "159 High St Liverpool EN5 4AA")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerEmail != "ThisisAlex@outlook.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestIsOver18Found()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.IsOver18 != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
