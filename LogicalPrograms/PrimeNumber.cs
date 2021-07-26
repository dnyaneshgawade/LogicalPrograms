using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public static int number;
        public static Boolean prime = false;
        public static void Prime()
        {
            Console.Write("Enter the Number : ");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number/2; i++)
            {
                if (number % i == 0 || number == 0 || number == 1)
                {
                    prime = false;

                }
                else
                {
                    prime = true;

                }
            }
            if (prime == true)
                Console.Write("Number is Prime.");
            else
                Console.Write("Number is not Prime.");
        }
    }
}
