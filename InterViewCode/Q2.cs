using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterViewCode
{
    class Q2
    {
        static void Main(string[] args)
        {
            int count;
            ThirdMethod(out count);
            Console.WriteLine(count);

            FirstMethod(count);
            Console.WriteLine(count);

            SecondMethod(ref count);
            Console.WriteLine(count);

            Console.ReadLine();
        }


        static void FirstMethod(int value)
        {
            value = 0;
           
        }
        static void SecondMethod(ref int value)
        {
            value = 1;
        }
        static void ThirdMethod(out int value)
        {
            value = 2;
        }
    }
}
