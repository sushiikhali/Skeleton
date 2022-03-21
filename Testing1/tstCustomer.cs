using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//v00egd00001l.lec-admin.dmu.ac.uk
namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        string CustomerName = "random name";
        int CustomerID = 1;
        DateTime CustomerDOB = DateTime.Now;
        string CustomerAddress = "4 South Road London E22 5MN ";
        string CustomerEmail = "example@outlook.com";
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
            string TestData = "some name ";
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
            string TestData = "4 South Road London E22 5MN  ";
            ACustomer.CustomerAddress = TestData;
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }
        [TestMethod]
        public void CustomerEmailOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "randomemail@outlook.com";
            ACustomer.CustomerEmail = TestData;
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        }
}
