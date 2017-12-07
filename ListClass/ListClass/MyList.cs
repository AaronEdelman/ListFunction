﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListClass
{
    public class MyList<T>
    {
        T[] myArray;
        int arrayCapacity = 0;
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
        //override '+' to add two instances of the list class together ("hello" + "world" = "hello world" && 1 + 1 = 1,1)
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
        //create .zip that will combine two int lists and organize by value
        //create .sort for list class (cannot use Array.Sort)
    }
}
