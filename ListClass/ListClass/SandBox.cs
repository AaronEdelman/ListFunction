using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListClass
{
    class SandBox
    {
        List<string> list1 = new List<string>() { "foo", "Bar", "hello" };
        List<string> list2 = new List<string>() { "foo", "Bar" };

        public void Subtract()
        {
            List<string> list3 = list1 + list2;
        }

    }
}
