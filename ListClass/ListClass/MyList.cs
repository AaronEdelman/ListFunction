﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListClass
{
    public class MyList<T> : IEnumerable , IComparable<T>
    {
        T[] myArray;
        int arrayCapacity = 0;
        int myElement;
        int myElementPlusOne;
        //constructor
        public MyList()
        {
            this.myArray = new T[0];
        }
        //indexer
        public T this[int number]
        {
            get
            {
                if (number >= 0 && number < myArray.Length)
                {
                    return myArray[number];
                }
                throw new IndexOutOfRangeException("list value does not exist.");
            }
            set
            {
                if (number >= 0 && number < myArray.Length)
                {
                    myArray[number] = value;
                }
            }
        }
        //add object to array
        public void Add(T value)
        {
            arrayCapacity++;
            Array.Resize(ref myArray, arrayCapacity);
            myArray[(myArray.Length - 1)] = value;
        }
        //remove object from array
        public void Remove(T value)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i].Equals(value))
                {
                    for (int j = i; j<myArray.Length-1; j++)
                    {
                        myArray[j] = myArray[j + 1];
                    }
                    arrayCapacity--;
                    Array.Resize(ref myArray, arrayCapacity);
                }
            }
        }
        //override ToString method
        public override string ToString()
        {
            string stringList = "";
            for (int i = 0; i < myArray.Length; i++)
            {
                stringList += string.Concat(myArray[i]);
            }
            return stringList;
        }
        //override '+' to add two instances of the list class together ("hello" + "world" = "hello world" && 1 + 1 = 11)
        public static MyList<T> operator +(MyList<T> listOne, MyList<T> listTwo)
        {
            try
            {
                for (int i = 0; i < listTwo.Count; i++)
                {
                    listOne.Add(listTwo[i]);
                }
                return listOne;
            }
            catch
            {
                throw new Exception("MyString data types must match");
            }
        
        }
        //override '-' to subtract two instances of the list class together
        public static MyList<T> operator -(MyList<T> listOne, MyList<T> listTwo)
        {
                for (int i = 0; i < listOne.Count; i++)
                {
                    for (int j = 0; j < listTwo.Count; j++)
                    {
                        if (listOne[i].Equals(listTwo[j]))
                        {
                            listOne.Remove(listOne[i]);
                        }
                    }
                }
                return listOne;
        }
        //create .count for list class
        public int Count
        {
            get
            {
                int count = myArray.Length;
                return count;
            }
        }
        //create .zip that will combine two lists
        public MyList<T> Zip(MyList<T> myListTwo)
        {
            MyList<T> myListThree = new MyList<T> { };
            int listCount = DetermineLongerList(myListTwo);
            for (int i = 0; i < listCount; i++)
            {
                try
                {
                    myListThree.Add(myArray[i]);
                }
                catch { }
                try
                {
                    myListThree.Add(myListTwo[i]);
                }
                catch { }
            }
            return myListThree;
        }
        private int DetermineLongerList(MyList<T>myListTwo)
        {
            int list = 0;
            if(myArray.Length>= myListTwo.Count)
            {
                list = myArray.Length;
            }
            if(myArray.Length<myListTwo.Count)
            {
                list = myListTwo.Count;
            }
            return list;
        }
        //create enumerator so that MyList is iterable.
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                yield return myArray[i];
            }
        }
        //create .sort for list class (cannot use Array.Sort ---- used bubble sort method)
        public void Sort()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length; j++)
                {
                    try
                    {
                        myElement = Convert.ToInt32(myArray[j]);
                        myElementPlusOne = Convert.ToInt32(myArray[j + 1]);
                        if (myElement.CompareTo(myElementPlusOne) > 0)
                        {
                            T firstElement = myArray[j];
                            T secondElement = myArray[j + 1];
                            myArray[j] = secondElement;
                            myArray[j + 1] = firstElement;
                        }
                    }
                    catch
                    { }
                }
            }
        }
        public int CompareTo(T other)
        {
            int otherInt = Convert.ToInt32(other);
            if (myElement > otherInt)
            {
                return 1;
            }
            if (myElement < otherInt || myElement == otherInt)
            {
                return -1;
            }
            else
            {
                throw new Exception("HELP!!!");
            }
        }
    }
}
