using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class Math
    {
        public delegate int MathOperation(int a, int b);

        internal static int Add(int x, int y)
        {
            return x + y;
        }
        internal static int Subtract(int x, int y)
        {
            return x - y;
        }

        internal static int Multiply(int x, int y)
        {
            return x * y;
        }

        internal static int Divide(int x, int y)
        {
            return x / y;
        }


        

    }
}
