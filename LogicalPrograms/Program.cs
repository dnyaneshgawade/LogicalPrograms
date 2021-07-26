using System;

namespace LogicalPrograms
{
    class Program
    {
        public static int choice;
        public const int IS_FIBONACCI = 1;
        public const int IS_PERFECT_NUMBER = 2;
        public const int IS_PRIME = 3;
        public const int IS_REVERSE = 4;
        public const int IS_COUPONS_NUMBER = 5;
        public const int IS_STOP_WATCH = 6;
        public const int IS_TEMP_CONVERSION = 7;
        public const int IS_DAY_OF_WEEK = 8;
        public const int IS_WENDING_MACHINE = 9;
        public const int IS_MONTHLY_PAYMENT = 10;
        public const int IS_DECIMAL_TO_BINARY = 11;
        public static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to 11 to run the Following programs !");
            Console.WriteLine("1. Fibonacci Series\n2. Perfect Number\n3. Prime Number\n4.Reversing a Number\n5. Coupon Numbers\n6. Stop_Watch\n7. Temparature Conversion\n8. Day Of Week\n9. Vending Machine \n10. Monthly_Payemnt \n11. Decimel to binary\n");
            while (choice != 12)
            {
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case IS_FIBONACCI:
                        Console.WriteLine("Fibonacci Series");
                        FibonacciSeries fibonacciSeries = new FibonacciSeries();
                        fibonacciSeries.Fibonacci();
                        break;
                    case IS_PERFECT_NUMBER:

                        Console.WriteLine("Perfect Number");
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.Perfect();
                        break;
                    case IS_PRIME:
                        Console.WriteLine("Prime Check");
                        PrimeNumber primeNumber = new PrimeNumber();
                        PrimeNumber.Prime();
                        break;

                    case IS_REVERSE:
                        Console.WriteLine("Reverse a Number");
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.Reverse();
                        break;

                    case IS_COUPONS_NUMBER:
                        Console.WriteLine("Unique Coupon number");
                        Coupons coupons = new Coupons();
                        Coupons.UniqueCoupons();
                        break;

                    
                    default:
                        Console.WriteLine("choose one more time");
                        break;
                }
            }
        }
        
    }
}
