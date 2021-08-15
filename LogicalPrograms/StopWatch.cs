using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace LogicalPrograms
{
    public class StopWatch
    {
        public static int choice;
        public static void Watch()
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Press 1 to begin the stopwatch");
            Console.WriteLine("Press 0 to stop the stopwatch");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                stopwatch.Start();
                choice = Convert.ToInt32(Console.ReadLine());
                while(choice!=0)
                {
                    System.Threading.Thread.Sleep(1);
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}
