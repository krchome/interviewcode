using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterViewCode
{
    class Q4
    {
        static void Main()
        {
            float firstValue = float.MaxValue;
            float secondValue = float.MaxValue;

            checked
            {
                float result = firstValue * secondValue;
                Console.WriteLine(result.ToString());
            }
        }
    }
}

