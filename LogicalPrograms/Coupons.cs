using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Coupons
    {
		public static void UniqueCoupons()
		{
			int N;
			int count = 0;
			Random random = new Random();
			Console.WriteLine("Enter the number of coupons");
			N = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[N + 1];
			for (int i = 0; i < N + 1; i++)
			{ arr[i] = random.Next(50); }

			for (int i = 0; i < N; i++)
			{
				Console.WriteLine(arr[i]);
				if (arr[i] == arr[i + 1])
				{
					count--;
				}
				else
				{

					count++;
				}


			}
			Console.WriteLine("The number of Unique coupons is : " + count);
		}
	}
}
