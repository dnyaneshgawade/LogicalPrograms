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
        public const int IS_NEWTONS_METHOD = 11;
        public const int IS_DECIMAL_TO_BINARY = 12;
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Fibonacci Series\n2. Perfect Number\n3. Prime Number\n4.Reversing a Number\n5. Coupon Numbers\n6. Stop_Watch\n7. Temparature Conversion\n8. Day Of Week\n9. Vending Machine \n10. Monthly_Payemnt \n11. Newton's method \n12. Decimel to binary\n");
            while (choice != 13)
            {
                Console.WriteLine("Enter Your Choice: ");
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
                        PrimeNumber.Prime();
                        break;

                    case IS_REVERSE:
                        Console.WriteLine("Reverse a Number");
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.Reverse();
                        break;

                    case IS_COUPONS_NUMBER:
                        Console.WriteLine("Unique Coupon number");
                        Coupons.UniqueCoupons();
                        break;

                    case IS_STOP_WATCH:
                        StopWatch.Watch();
                        break;
                    case IS_TEMP_CONVERSION:
                        TempConversion tempconversion = new TempConversion();
                        tempconversion.Conversion();
                        break;
                    case IS_DAY_OF_WEEK:
                        DayOfWeek dayOfWeek = new DayOfWeek();
                        dayOfWeek.Day();
                        break;
                    case IS_WENDING_MACHINE:

                        break;
                    case IS_MONTHLY_PAYMENT:
                        MonthlyPayment.Payment();
                        break;
                    case IS_NEWTONS_METHOD:
                        NewtonsMethod.Sqrt();
                        break;
                    case IS_DECIMAL_TO_BINARY:
                        DecimalToBinary.Binary();
                        break;
                   
                    default:
                        Console.WriteLine("Oops!!! Try Again.");
                        break;
                }
            }
        }
    }
}
