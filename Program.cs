using System;

namespace Fib
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			int sum = 0;					     //This will be the sum of j and k (current and next values in the sequence)
			int j = 1;					     //This will be the 'current' value we are checking in the sequence
			int k = 1;					     //This will be used to hold the sum of the current and immediate next values
			int upperlimit = 4000000;			     //This is the max number our sequence will go to
			int evensum = 0;				     //This will add up all the even values

			while(j <= upperlimit)				     //Run the loop while our current value is less than or equal to our upperlimit
			{

				if (j % 2 == 0) {			     //This is a modulas operator - It gives us the reminder of division. If you divide by 2 and end up with no remainder, you have an even number
					Console.WriteLine (j + " " + "*");   //Star our even numbers to check the logic
					evensum += j;			     // += will add the current value of evensum AND j, a longer form would look like this: evensum = evensum + j;
				} else {
					Console.WriteLine (j);		     //Just display the odd numbers
				}
				sum=j+k;				     //sum keeps track of the current and next values because the Fib. sequences next number is the previous two digits added together
				j=k;					     //After we are 'done' with j, we move the sequence ahead by giving it k's value 
				k=sum;					     //This is what actually advances the sequence (this and sum=j+k) k will become the actual 'next' value here and then j will advance on the next loop iteration
			}

			Console.WriteLine ("Even Sums = " + evensum);
		}
	}
}
