using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterViewCode
{
    class Q9
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("A");
            }
            catch (Exception)
            {
                Console.WriteLine("B");
            }
            finally
            {
                Console.WriteLine("C");
            }
            Console.ReadKey();
        }
    }
}
