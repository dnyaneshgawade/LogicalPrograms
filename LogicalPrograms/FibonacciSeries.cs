using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public void Fibonacci()
        {
            int num1 = 0;
            int num2 = 1;
            int num3;
            int number;
            Console.Write("Enter  number of elements: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write(num1 + " " + num2 + " ");
            for (int i = 2; i < number; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
