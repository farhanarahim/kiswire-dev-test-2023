
using System;

class GFG{

	
	static int findSum(int n)
	{
		int sum = 0;
		for (int x = 1; x <= n; x++)
			sum = sum + x;
		return sum;
	}

	public static void Main()
	{
		int n = 5;
		Console.Write(findSum(n));
	}
}
