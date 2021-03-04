using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;

namespace ArrayListUnitTes
{
    [TestClass]
    public class UnitTest1
    {
        ArrayList al = new ArrayList();
       
        [TestMethod]
        public void AddAndGetTest()
        {
            //Assert
            Assert.ThrowsException<Exception>(() => al.Get(0));
            al.Add(23);
            Assert.AreEqual(23, al.Get(0));
            al.Add(55);
            Assert.AreEqual(55, al.Get(1));
            Assert.AreEqual(23, al.Get(0));
            Assert.ThrowsException<Exception>(() => al.Get(-1));
        }
        [TestMethod]
        public void SetTest()
        {
            //Assert
            Assert.ThrowsException<Exception>(() => al.Set(0,10));
            al.Add(23);
            al.Add(89);
            al.Set(1, 24);
            Assert.AreEqual(24, al.Get(1));
            Assert.ThrowsException<Exception>(() => al.Set(3,77));
            Assert.ThrowsException<Exception>(() => al.Set(-2, 34));

        }
        [TestMethod]
        public void InsertTest()
        {
            //Assert
            Assert.ThrowsException<Exception>(() => al.Set(0, 10));
            al.Add(23);
            al.Add(89);
            al.Add(9);
            al.Add(21);
            al.Add(12);
            al.Insert(5, 24);
            Assert.AreEqual(24, al.Get(5));
            Assert.AreEqual(12, al.Get(4));
            Assert.AreEqual(6, al.Count);
            al.Insert(1, 35);
            Assert.AreEqual(35, al.Get(1));
            Assert.AreEqual(89, al.Get(2));
            Assert.AreEqual(7, al.Count);
            Assert.ThrowsException<Exception>(() => al.Insert(8, 77));
            Assert.ThrowsException<Exception>(() => al.Insert(-1, 34));
        }
        [TestMethod]
        public void DeleteTest()
        {
            //Assert
            Assert.ThrowsException<Exception>(() => al.Delete(0));
            al.Add(23);
            al.Add(89);
            al.Add(9);
            al.Add(21);
            al.Add(12);
            al.Delete(4);
            Assert.AreEqual(4, al.Count);
            Assert.ThrowsException<Exception>(() => al.Get(4));
            al.Delete(1);
            Assert.AreEqual(9, al.Get(1));
            Assert.AreEqual(3, al.Count);
            Assert.ThrowsException<Exception>(() => al.Delete(-1));
            Assert.ThrowsException<Exception>(() => al.Delete(9));
        }
        [TestMethod]
        public void ContainsTest()
        {
            //Assert
            Assert.ThrowsException<Exception>(() => al.Contains(35));
            al.Add(23);
            al.Add(89);
            al.Add(77);
            al.Add(34);
            al.Add(99);
            Assert.AreEqual(true, al.Contains(89));
            Assert.AreEqual(true, al.Contains(23));
            Assert.AreEqual(false, al.Contains(65));
            Assert.AreEqual(false, al.Contains(82));
        }
        [TestMethod]
        public void PrintTest()
        {
            //Assert
            Assert.ThrowsException<Exception>(() => al.Print());
            al.Add(23);
            al.Add(89);
            al.Add(77);
            al.Add(34);
            al.Add(99);
            Assert.AreEqual("[23,89,77,34,99]", al.Print());
        }
    }
}
