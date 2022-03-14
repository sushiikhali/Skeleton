using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        private string nName = "random name";



        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer Acustomer = new clsCustomer();
            Assert.IsNotNull(Acustomer);
        }
        [TestMethod]
        public void NameOK()
        {
            clsCustomer Acustomer = new clsCustomer();
            string TestData = nName;
            Acustomer.Name = TestData;
            Assert.AreEqual(Acustomer.Name, TestData);

        }

        [TestMethod]
        public void ValidOK()
        {
            clsCustomer Acustomer = new clsCustomer();
            string Error = "";
            string TestData = nName;
            Error = Acustomer.Valid(nName);
            Acustomer.Name = TestData;
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MinLessOne()
        {
            clsCustomer Acustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            Error = Acustomer.Valid(TestData);
            Acustomer.Name = TestData;
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void MaxPlusOne()
        {
            clsCustomer Acustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(51, '*');
            Error = Acustomer.Valid(TestData);
            Acustomer.Name = TestData;
            Assert.AreNotEqual(Error, "");
        }
    }
}
