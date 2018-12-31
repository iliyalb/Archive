using System;

class Sum
{
	public static void Main()
    {
		string[] s = Console.ReadLine().Split();
		int a = int.Parse(s[0]);
		int b = int.Parse(s[1]);
		Console.WriteLine(a + b);
	}
}