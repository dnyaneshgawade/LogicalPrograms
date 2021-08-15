using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class NewtonsMethod
    {
        public static void Sqrt()
        {
            Console.WriteLine("Enter a number :");
            double c = Convert.ToDouble(Console.ReadLine());
            double epsilon = 1e-15;
            double t = c;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            Console.WriteLine("Square root of the number " + c + " is: " + t);
        }
    }
}
