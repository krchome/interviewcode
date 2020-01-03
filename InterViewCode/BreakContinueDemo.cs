using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterViewCode
{
    class BreakContinueDemo
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Output with break:");
            for (int i = 0; i <= 5; i++)
            {
                if (i == 4)
                {
                    break;
                }
                
                Console.WriteLine("The number is " + i);
               
            }
            Console.WriteLine("Output with continue:");
            for (int i = 0; i <= 5; i++)
            {
                if (i == 4)
                {
                    continue;
                }
               
                Console.WriteLine("The number is " + i);
               
            }
        }
    }
}  
    