using System;
using System.Linq;

public class Program
{

	public static void ConvertToNumberSystem(int n)
	{
		int b = 0;
		string str = string.Empty;

		while( n != 0)
        {
			str += n % 2;
			b += n % 2;
			n /= 2;
		}
		Console.WriteLine(str);
		Console.WriteLine("\n" + b);

	}

	public static void Main()
	{
		ConvertToNumberSystem(1234);
	}
}