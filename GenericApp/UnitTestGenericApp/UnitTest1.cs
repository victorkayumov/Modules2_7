using System;
using System.Linq;
using GenericApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGenericApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddKey_IncreaseCount_IsTrue()
        {
            var multiDictionary = new MultiDictionary<int, string>();
            multiDictionary.Add(4, "four");
            multiDictionary.Add(4, "five");

            Assert.IsTrue(multiDictionary.Count==2);
        }

        [TestMethod]
        public void AddKey_IncreaseCount_IsFlse()
        {
            var multiDictionary = new MultiDictionary<int, string>();
            multiDictionary.Add(4, "four");
            multiDictionary.Add(4, "five");

            Assert.IsFalse(multiDictionary.Count == 9);
        }

        [TestMethod]
        public void Remove_KeyWithSpesificValue_IsTrue()
        {
            var multiDictionary = new MultiDictionary<int, string>();
            multiDictionary.Add(4, "four");
            Assert.IsTrue(multiDictionary.Remove(4, "four"));
        }

        [TestMethod]
        public void Remove_KeyWithSpesificValue_IsFalse()
        {
            var multiDictionary = new MultiDictionary<int, string>();
            multiDictionary.Add(4, "four");
            Assert.IsFalse(multiDictionary.Remove(5, "four"));
        }

        [TestMethod]
        public void Remove_Key_IsTrue()
        {
            var multiDictionary = new MultiDictionary<int, string>();
            multiDictionary.Add(4, "four");
            multiDictionary.Add(4, "five");
            multiDictionary.Add(4, "six");
            Assert.IsTrue(multiDictionary.Remove(4));
        }

        [TestMethod]
        public void Clear_Dictionary_IsTrue()
        {
            var multiDictionary = new MultiDictionary<int, string>();
            multiDictionary.Add(4, "four");
            multiDictionary.Add(4, "five");
            multiDictionary.Add(6, "two");
            multiDictionary.Clear();
            Assert.IsTrue(multiDictionary.Count == 0);
        }

        [TestMethod]
        public void Count_TotalKeys_AreEqual()
        {
            var multiDictionary = new MultiDictionary<int, string>();
            multiDictionary.Add(1, "one");
            multiDictionary.Add(1, "ich");
            multiDictionary.Add(2, "two");
            multiDictionary.Add(3, "three");
            multiDictionary.Add(4, "four");

            Assert.AreEqual(5,multiDictionary.Count);
        }

        [TestMethod]
        public void Check_ContainsKey_IsTrue()
        {
            var multiDictionary = new MultiDictionary<int, string>();
            multiDictionary.Add(4, "four");

            Assert.IsTrue(multiDictionary.ContainsKey(4));
        }

        [TestMethod]
        public void Check_ContainsKeyAndValue_IsTrue()
        {
            var multiDictionary = new MultiDictionary<int, string>();
            multiDictionary.Add(5, "five");

            Assert.IsTrue(multiDictionary.Contains(5, "five"));
        }

   


    }
}
