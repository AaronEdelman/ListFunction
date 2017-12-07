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
            Assert.AreEqual(2, list.Count);
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
        [TestMethod]
        public void Plus_StringLists_PositiveCount()
        {
            //Arrange
            MyList<string> list1 = new MyList<string>();
            MyList<string> list2 = new MyList<string>();
            list1.Add("foo");
            list2.Add("bar");
            //Act
            MyList<string> list3 = list1 + list2;
            //Assert
            Assert.AreEqual(2, list3.Count);
        }
        [TestMethod]
        public void Plus_StringLists_String()
        {
            //Arrange
            MyList<string> list1 = new MyList<string>();
            MyList<string> list2 = new MyList<string>();
            list1.Add("foo");
            list2.Add("bar");
            //Act
            MyList<string> list3 = list1 + list2;
            //Assert
            Assert.AreEqual("bar", list3[1]);
        }
        [TestMethod]
        public void Plus_IntLists_PositiveCount()
        {
            //Arrange
            MyList<int> list1 = new MyList<int>();
            MyList<int> list2 = new MyList<int>();
            list1.Add(2);
            list2.Add(1);
            //Act
            MyList<int> list3 = list1 + list2;
            //Assert
            Assert.AreEqual(2, list3.Count);
        }
        [TestMethod]
        public void Plus_IntLists_PositiveInt()
        {
            //Arrange
            MyList<int> list1 = new MyList<int>();
            MyList<int> list2 = new MyList<int>();
            list1.Add(2);
            list2.Add(1);
            //Act
            MyList<int> list3 = list1 + list2;
            //Assert
            Assert.AreEqual(2, list3[0]);
        }
        [TestMethod]
        public void Minus_StringLists_ShorterList()
        {
            //Arrange
            MyList<string> list1 = new MyList<string>();
            MyList<string> list2 = new MyList<string>();
            list1.Add("foo");
            list1.Add("bar");
            list2.Add("bar");
            //Act
            MyList<string> list3 = list1 - list2;
            //Assert
            Assert.AreEqual(1, list3.Count);
        }
        [TestMethod]
        public void Minus_StringLists_NoChange()
        {
            //Arrange
            MyList<string> list1 = new MyList<string>();
            MyList<string> list2 = new MyList<string>();
            list1.Add("foo");
            list1.Add("bar");
            list2.Add("hello");
            //Act
            MyList<string> list3 = list1 - list2;
            //Assert
            Assert.AreEqual(2, list3.Count);
        }
        [TestMethod]
        public void Minus_StringLists_String()
        {
            //Arrange
            MyList<string> list1 = new MyList<string>();
            MyList<string> list2 = new MyList<string>();
            list1.Add("foo");
            list1.Add("bar");
            list2.Add("foo");
            //Act
            MyList<string> list3 = list1 - list2;
            //Assert
            Assert.AreEqual("bar", list3[0]);
        }
        public void Minus_IntLists_Int()
        {
            //Arrange
            MyList<int> list1 = new MyList<int>();
            MyList<int> list2 = new MyList<int>();
            list1.Add(1);
            list1.Add(2);
            list2.Add(3);
            //Act
            MyList<int> list3 = list1 - list2;
            //Assert
            Assert.AreEqual(1, list3[0]);
        }
        [TestMethod]
        public void Minus_IntLists_PositiveCount()
        {
            //Arrange
            MyList<int> list1 = new MyList<int>();
            MyList<int> list2 = new MyList<int>();
            list1.Add(2);
            list2.Add(1);
            //Act
            MyList<int> list3 = list1 - list2;
            //Assert
            Assert.AreEqual(1, list3.Count);
        }
    }
}
