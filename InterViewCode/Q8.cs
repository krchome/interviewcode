using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterViewCode
{
    class StaticTest
    {
        public static int TestValue;
        public StaticTest()
        {
            if (TestValue == 0)
            {
                TestValue = 5;
            }
        }
        static StaticTest()
        {
            if (TestValue == 0)
            {
                TestValue = 10;
            }

        }
        public void Print()
        {
            if (TestValue == 5)
            {
                TestValue = 6;
            }
            Console.WriteLine("TestValue : " + TestValue);

        }
        static void Main(string[] args)
        {
            StaticTest t = new StaticTest();
            t.Print();    
        }
    }

   
}
