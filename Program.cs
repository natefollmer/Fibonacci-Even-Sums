using System;

namespace Fib
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			int sum = 0;
			int j = 1;
			int k = 1;
			int upperlimit = 4000000;
			int evensum = 0;

			while(j <= upperlimit)
			{

				if (j % 2 == 0) {
					Console.WriteLine (j + " " + "*");
					evensum += j;
				} else {
					Console.WriteLine (j);
				}
				sum=j+k;
				j=k;
				k=sum;
			}

			Console.WriteLine ("Even Sums = " + evensum);
		}
	}
}
