using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListClass;

namespace ListClassTesting
{
    [TestClass]
    public class MyListTests
    {
        [TestMethod]
        public void Indexer_StringAtIndex0_SetStringAtIndex0()
        {
            //Arrange
            MyList<string> list = new MyList<string>();
            list.Add("hello");
            string bar = "foo";
            //Act
            list[0] = bar;
            //Assert
            Assert.AreEqual("foo", bar);
        }
        [TestMethod]
        [ExpectedException(typeof(System.IndexOutOfRangeException))]
        public void Indexer_ElementOutOfRange_Exception()
        {
            //Arrange
            MyList<string> list = new MyList<string>();
            //Act
            string foo = list[2];
            //Assert
        }
        [TestMethod]
        public void Indexer_StringAtIndex0_GetStringAtIndex0()
        {
            //Arrange
            MyList<string> list = new MyList<string>();
            list.Add("foo");
            //Act
            string bar = list[0];
            //Assert
            Assert.AreEqual("foo", bar);
        }
        [TestMethod]
        public void Add_String_ArrayCountAddOne()
        {
            //Arrange
            MyList<string> list = new MyList<string>();
            string text = "hello";
            //Act
            list.Add(text);
            //Assert
            //Assert.AreEqual(1, list.Count);
        }
        [TestMethod]
        public void Add_Int_ArrayCountAddTwo()
        {
            //Arrange
            MyList<int> list = new MyList<int>();
            int number = 3;
            //Act
            list.Add(number);
            list.Add(number);
            //Assert.AreEqual(2, list.Count);
        }
        [TestMethod]
        public void Add_String_RetrieveString()
        {
            //Arrange
            MyList<string> list = new MyList<string>();
            string text = "hello";
            //Act
            list.Add(text);
            //Assert
            Assert.AreEqual("hello", list[0]);
        }
    }
}
