using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListClass
{
    class SandBox
    {
        MyList<string> list1 = new MyList<string>();
        MyList<string> list2 = new MyList<string>();

        public void Subtract()
        {
            list1.Add("foo");
            list1.Add("bar");
            list2.Add("bar");
            MyList<string> list3 = list1 - list2;
            Console.WriteLine("hello");
            Console.ReadLine();
        }


    }
}
