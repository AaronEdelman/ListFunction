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

        public void ZipTest()
        {
            list1.Add("1");
            list1.Add("3");
            list2.Add("4");
            MyList<string> list3 = list1.Zip(list2);
            Console.WriteLine(list3[0] + list3[1] + list3[2]);
            Console.ReadLine();
        }


    }
}
