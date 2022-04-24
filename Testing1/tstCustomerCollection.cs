using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
        [TestMethod ]
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
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

    }
}