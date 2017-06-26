using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
			string input;
			do
			{

				Console.WriteLine("Enter length:");
				string length = Console.ReadLine();
				Console.WriteLine("Enter width:");
				string width = Console.ReadLine();
				double x = double.Parse(length);
				double y = double.Parse(width);
				double area = x * y;
				Console.WriteLine(area + " is your rooms area");
				double perimeter = ((2 * x) + (2 * y));
				Console.WriteLine(perimeter + " is your rooms perimeter");

				Console.WriteLine("Continue: y/n?");
				input = Console.ReadLine();
			}
			while (input == "y");
			




			
		}
	}
}
