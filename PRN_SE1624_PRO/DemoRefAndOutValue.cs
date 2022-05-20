using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_SE1624_PRO
{
    class DemoRefAndOutValue
    {
        public static void MyMethod(int a, ref int b, out int c)
        {
            a = 5;
            b = 2;
            c = 4;
        }
    }
}
