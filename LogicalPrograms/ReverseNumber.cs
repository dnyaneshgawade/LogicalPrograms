using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        int reverse = 0, remainder;
        int number = Convert.ToInt32(Console.ReadLine());
        public int Reverse()
        {
            Console.WriteLine("Enter the Number");
            while (number > 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }
            return reverse;
        }
    }
}
