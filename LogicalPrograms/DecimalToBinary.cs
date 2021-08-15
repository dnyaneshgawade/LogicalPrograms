using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class DecimalToBinary
    {
        public static void Binary()
        {
            string answer;
            string result;

            Console.Write("Enter a Number : ");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Conversion of Decimal to Binary is : {0}", result);
        }
    }
}
