using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterViewCode
{
    class Q3
    {
        static void Main()
        {
            unsafe
            {
                int a = 15;
                int* b = &a; 
                Console.WriteLine(*b);
            }
        }
    }
}
