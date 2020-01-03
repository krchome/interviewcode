using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterViewCode
{
    public sealed class Circle
    {
        private double radius = 1.0;

        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }

      
    }


    public class TestCircle
    {
            static void Main()
            {
                Circle circle = new Circle();

                double circumference = circle.Calculate(r => 2 * Math.PI * r);
                Console.WriteLine(circumference);
                Console.ReadLine();
            }

    }
    

    
}
