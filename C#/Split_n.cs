using System;

class Sum
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		string[] s = Console.ReadLine().Split();
		int sum = 0;
		for (int i = 0 ; i < n ; i++)
		{
			sum += int.Parse(s[i]);
		}
		Console.WriteLine(sum);
	}
}