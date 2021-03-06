using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack_Library4;

namespace StatckTest
{
    [TestClass]
    public class UnitTest1
    {
        Stack st = new Stack(5);
        [TestMethod]
        public void PushTest()
        {
            //Assert
            Assert.AreEqual(0, st.Count);
            st.push(3);
            st.push(13);
            st.push(23);
            st.push(34);
            Assert.AreEqual(4, st.Count);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PushTest1()
        {

            //Assert
            //Assert
            Assert.AreEqual(0, st.Count);
            st.push(3);
            st.push(13);
            st.push(23);
            st.push(34);
            st.push(35);
            st.push(55);
        }
        [TestMethod]
        public void PopTest()
        {
            //Assert
            Assert.AreEqual(0, st.Count);
            st.push(3);
            st.push(13);
            st.push(23);
            Assert.AreEqual(23,st.pop());
            Assert.AreEqual(2, st.Count);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PopTest1()
        {
            //Assert
           
            st.push(3);
            st.push(13);
            st.push(23);
            st.push(34);
            st.pop();
            st.pop();
            st.pop();
            Assert.AreEqual(3, st.pop());
            st.pop();
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PopTest2()
        {
            //Assert
            st.pop();
        }
        [TestMethod]
        public void PeekTest()
        {
            //Assert
            Assert.AreEqual(0, st.Count);
            st.push(3);
            st.push(13);
            st.push(23);
            Assert.AreEqual(3, st.Count);
            Assert.AreEqual(23, st.peek());
            Assert.AreEqual(3, st.Count);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PeekTest1()
        {
            //Assert
            st.peek();
        }
        [TestMethod]
        public void PrintTest1()
        {
            //Assert
            //Assert
            Assert.AreEqual(0, st.Count);
            st.push(3);
            st.push(13);
            st.push(23);
            st.push(34);
            st.push(35);
            string check = "35 34 23 13 3 ";
            Assert.AreEqual(check, st.Print());
        }
    }
}
