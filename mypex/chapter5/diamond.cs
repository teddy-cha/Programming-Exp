using System;

namespace DiamondPattern
{
	class DiamondPattern
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Progrma for displaying patter of *.");
			Console.Write("Enter the maximun number of *: ");
			int n = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("\nHere is the Diamond of stars\n");

			for (int i = 1; i <= n; i++)
			{
				for (int j = 0; j < (n - i); j++)
					Console.Write(" ");
				for (int j = 1; j <= i; j++)
					Console.Write("*");
				for (int k = 1; k < i; k++)
					Console.Write("*");
				Console.WriteLine();
			}
			for (int i = n - 1; i <= 1; i--)
			{
				for (int j = 0; j < (n - 1); j++)
					Console.Write(" ");
				for (int j = 1; j <= i; j++)
					Console.Write("*");
				for (int k = 1; k < i; k++)
					Console.Write("*");
				Console.WriteLine();
		
			}

			Console.WriteLine();
	}
}

