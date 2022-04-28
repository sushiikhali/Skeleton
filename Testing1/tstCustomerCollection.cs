using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
//v00egd00001l.lec-admin.dmu.ac.uk
namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
        }
        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.IsOver18 = true;
            TestItem.CustomerAddress = "159 High St Liverpool EN5 4AA";
            TestItem.CustomerDOB = DateTime.Now.AddYears(-18);
            TestItem.CustomerEmail = "ThisisAlex@outlook.com";
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Alex Wong";
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }


        [TestMethod]
        public void ThisCustomersPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.IsOver18 = true;
            TestCustomer.CustomerAddress = "159 High St Liverpool EN5 4AA";
            TestCustomer.CustomerDOB = DateTime.Now.AddYears(-18);
            TestCustomer.CustomerEmail = "ThisisAlex@outlook.com";
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerName = "Alex Wong";
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.IsOver18 = true;
            TestItem.CustomerAddress = "159 High St Liverpool EN5 4AA";
            TestItem.CustomerDOB = DateTime.Now.AddYears(-18);
            TestItem.CustomerEmail = "ThisisAlex@outlook.com";
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Alex Wong";
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.IsOver18 = true;
            TestItem.CustomerAddress = "159 High St Liverpool EN5 4AA";
            TestItem.CustomerDOB = DateTime.Now.AddYears(-18);
            TestItem.CustomerEmail = "ThisisAlex@outlook.com";
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Alex Wong";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.IsOver18 = true;
            TestItem.CustomerAddress = "159 High St Liverpool EN5 4AA";
            TestItem.CustomerDOB = DateTime.Now.AddYears(-18);
            TestItem.CustomerEmail = "ThisisAlex@outlook.com";
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Alex Wong";
            //setting this Address to the test data 
            AllCustomers.ThisCustomer = TestItem;
            //adding the record
            PrimaryKey = AllCustomers.Add();
            //setting the primary key of the test data 
            TestItem.CustomerID = PrimaryKey;
            //finding the record 
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //deleting the record
            AllCustomers.Delete();
            //finding the record that has been currently deleted
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //testing to see the record was not found
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void UpdateOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.IsOver18 = true;
            TestItem.CustomerAddress = "159 High St Liverpool EN5 4AA";
            TestItem.CustomerDOB = DateTime.Now.AddYears(-18);
            TestItem.CustomerEmail = "ThisisAlex@outlook.com";
            // TestItem.CustomerID = 1;
            TestItem.CustomerName = "Alex Wong";
            AllCustomers.ThisCustomer = TestItem;
            /// Adding the record 
            PrimaryKey = AllCustomers.Add();
            //setting primary key to test data 
            TestItem.CustomerID = PrimaryKey;
            //modifying the test data 
            TestItem.IsOver18 = false;
            TestItem.CustomerAddress = "429 Low St Leeds LEE SDA";
            TestItem.CustomerDOB = DateTime.Now.AddYears(-18);
            TestItem.CustomerEmail = "ThisisPam@outlook.com";
            //  TestItem.CustomerID = 1;
            TestItem.CustomerName = "Pam Sam";
            //setting record based on new test data
            AllCustomers.ThisCustomer = TestItem;
            //updating the record 
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }
        [TestMethod]
        public void ReportByCustomerAddressMethodOK()
        {
            //create an instance of the class containing unfilteres results 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //applyig a blank string 
            FilteredCustomers.ReportByAddress("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByCustomerAddressNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //appyling address that does not exist
            FilteredCustomers.ReportByAddress("any random address 12345");
            //test to see that there are no records 
            Assert.AreEqual(0, FilteredCustomers.Count);

        }
        [TestMethod]
        public void ReportByAddressTestDataFound()
        {
            //create instance of filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //varibale to store outcome 
            Boolean OK = true;
            //applying address that does not exist 
            FilteredCustomers.ReportByAddress("yan darmon drssae 32451");
            //check that correct number of records are found 
            if(FilteredCustomers.Count == 2)
            {
                //check that the first record is ID 36
                if(FilteredCustomers.CustomerList[0].CustomerID != 36)
                {
                    OK = false;
                } 
                //check that the first record is ID 37
                if(FilteredCustomers.CustomerList[1].CustomerID != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
      