using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterViewCode
{
    class Q6
    {
        private static string result;
        static void Main()
        {
            MessageFromTheMethod();
            Console.WriteLine($"This is returned from the method: {result}");
            Console.ReadLine();
        }
        static async Task<string> MessageFromTheMethod()
        {
            await Task.Delay(5);
            result = "Hello world!";
            return "Something";
        }
    }
}
