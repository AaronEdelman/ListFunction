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
            Assert.AreEqual(1, list.Count);
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
        [TestMethod]
        public void Remove_String_ArrayCountMinusOne()
        {
            //Arrange
            MyList<string> list = new MyList<string>();
            string text1 = "foo";
            string text2 = "bar";
            list.Add(text1);
            list.Add(text2);
            //Act
            list.Remove("foo");
            //Assert
            Assert.AreEqual(1, list.Count);
        }
        [TestMethod]
        public void Remove_int_Element3At2Space()
        {
            //Arrange
            MyList<int> list = new MyList<int>();
            int number1 = 1;
            int number2 = 2;
            list.Add(number2);
            list.Add(number1);
            list.Add(number2);
            //Act
            list.Remove(1);
            //Assert
            Assert.AreEqual(2, list[1]);
        }
        [TestMethod]
        public void Remove_int_NoChangeToList()
        {
            //Arrange
            MyList<int> list = new MyList<int>();
            int number1 = 1;
            int number2 = 2;
            list.Add(number2);
            list.Add(number1);
            list.Add(number2);
            //Act
            list.Remove(3);
            //Assert
            Assert.AreEqual(3, list.Count);
        }
        [TestMethod]
        public void Remove_StringFromEmpty_EmptyList()
        {
            //Arrange
            MyList<string> list = new MyList<string>();
            //Act
            list.Remove("foo");
            //Assert
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void Count_Nothing_0()
        {
            //Arrange
            //Act
            MyList<int> list = new MyList<int>();
            //Assert
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void Count_Ints_PositiveInt()
        {
            //Arrange
            MyList<int> list = new MyList<int>();
            int number = 3;
            list.Add(number);
            list.Add(number);
            list.Add(number);
            //Act
            //Assert
            Assert.AreEqual(3, list.Count);
        }
    }
}
