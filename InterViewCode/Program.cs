
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterViewCode
{
    class Program
    {
        class Animal
        {
            public void WriteMessage(int q)
            {
                Console.WriteLine("Message from A");
            }
        }

        class Bull : Animal
        {
            public void WriteMessage(double p)
            {
                Console.WriteLine("Message from B");
            }
        }

        static void Main(string[] args)
        {
            int i = 5;
            Bull b = new Bull();
            b.WriteMessage(i);
            Console.ReadLine();
        }
    }
}
