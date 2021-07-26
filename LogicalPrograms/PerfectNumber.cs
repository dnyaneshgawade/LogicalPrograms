using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public int sum = 0;
        public int number = Convert.ToInt32(Console.ReadLine());
        public void Perfect()
        {
            Console.WriteLine("Enter the number:");
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            if (sum == number)
                Console.WriteLine(number  + " Is a Perfect Number.");
            else
                Console.WriteLine(number +  " Is a not Perfect Number.");
        }
    }
}
