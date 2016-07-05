using System;
using CustomersApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCustomersApp
{
    [TestClass]
    public class UnitTest1 
    {
        [TestMethod]
        public void Compare_TwoNames_AreEqual()
        {
            var customer = new Customer("VICTOR", 2, "maalot");

            Assert.AreEqual(0, customer.Name.ToUpper().CompareTo("victor".ToUpper()));
        }

        [TestMethod]
        public void CheckISEqual_TwoNames_IsTrue()
        {
            var customer1 = new Customer("victor", 1, "karmiel");
            var customer2 = new Customer("victor", 2, "maalot");

            Assert.IsTrue(customer1.Name.Equals(customer2.Name));
        }
        [TestMethod]
        public void CheckISEqual_TwoId_IsTrue()
        {
            var customer1 = new Customer("victor", 2, "karmiel");
            var customer2 = new Customer("victor", 2, "maalot");

            Assert.IsTrue(customer1.Id.Equals(customer2.Id));
        }

        [TestMethod]
        public void Compare_TwoId_AreEqual()
        {
            var customer1 = new Customer("victor", 3, "karmiel");
            var customer2 = new Customer("victor", 3, "maalot");

            Assert.AreEqual(0, customer1.Id.CompareTo(customer2.Id));
        }
    }
}
