using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
//v00egd00001l.lec-admin.dmu.ac.uk
namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        string CustomerName = "Alex Wong";
        int CustomerID = 1;
        string CustomerDOB = DateTime.Now.AddYears(-18).ToString();
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
            if (ACustomer.CustomerID != 1)
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
        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
    


        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "";
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "w";
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "ww";
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(49, 'w');
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(50, 'w');
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(51, 'w');
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(25, 'w');
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxExtreme()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(1000, 'w');
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(0);
            string CustomerDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreNotEqual(Error, "");
         
        }
        [TestMethod]
        public void CustomerDOBMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-17);
            string CustomerDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDOBMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-18);
            string CustomerDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDOBMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-19);
            string CustomerDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDOBEMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-99);
            string CustomerDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDOBMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string CustomerDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDOBMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-101);
            string CustomerDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreNotEqual(Error, "");
            
        }
        [TestMethod]
        public void CustomerDOBExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error ="";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1000);
            string CustomerDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreNotEqual(Error,"");
            
        }
        [TestMethod]
        public void CustomerDOBMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-59);
            string CustomerDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDOBInvalidData()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerDOB = "This is not a date.";
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreNotEqual(Error, "");
          
        }
        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = "w";
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMinPLusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = "ww";
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(49, 'w');
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(50, 'w');
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(51, 'w');
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(25, 'w');
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(1000, 'w');
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "w";
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "ww";
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(49, 'w');
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(50, 'w');
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(51, 'w');
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(25, 'w');
            Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerAddress, CustomerEmail);
            Assert.AreEqual(Error, "");
        }


    }

}