using System;
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
            int length = myArray.Length;
            myArray[(myArray.Length - 1)] = value;
        }
        //remove object
        //override ToString method
        //override '+' to add two instances of the list class together (ie 1+1 = 2 & "hello" + "world" = "hello world")
        //override '-' to add two instances of the list class together
        //create .count for list class
        //create .zip that will combine two int lists and organize by value
        //create .sort for list class (cannot use Array.Sort)
    }
}
