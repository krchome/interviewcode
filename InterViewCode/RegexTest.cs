using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterViewCode
{
    class RegexTest
    {
        static void Main(string[] args)
        {
            string[] animals = {"cat","dog","goat"};
             foreach (string animal in animals)
             {
                if (System.Text.RegularExpressions.Regex.IsMatch(animal,"cow"))
                {
                    Console.WriteLine("Match found");
                }    
            }
        }
    }
}
