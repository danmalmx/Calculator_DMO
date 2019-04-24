using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			bool value = true;
			while (value != false)
			{
				Console.Write("Enter a number (or enter 0 to exit): ");
				int num1 = int.Parse(Console.ReadLine());

				if (num1 == 0)
				{
					value = false;
					Console.WriteLine();
					Console.WriteLine("Thank you for using this calculator");
					break;
				}

				Console.Write("Enter another number (or enter 0 to exit): ");
				int num2 = int.Parse(Console.ReadLine());

				if (num1 == 0 || num2 == 0)
				{
					value = false;
					Console.WriteLine();
					Console.WriteLine("Thank you for using this calculator");
					break;
				}

				Console.Write("Enter an operator: + (or plus), - (or minus), * (or multiply), or / (or divide) or enter 0 to exit: ");
				string opr = Convert.ToString(Console.ReadLine());

				if (num1 == 0 || num2 == 0 || opr == "0")
				{
					value = false;
					Console.WriteLine();
					Console.WriteLine("Thank you for using this calculator");
					break;
				}

				if (opr == "+" || opr == "plus")
				{
					Console.WriteLine("{0} + {1} = {2}", num1, num2, Add(num1, num2));

				}
				else if (opr == "-" || opr == "minus")
				{
					Console.WriteLine("{0} - {1} = {2}", num1, num2, Subtract(num1, num2));

				}
				else if (opr == "*" || opr == "multiply")
				{
					Console.WriteLine("{0} * {1} = {2}", num1, num2, Multiply(num1, num2));

				}
				else
				{
					Console.WriteLine("{0} / {1} = {2}", num1, num2, Divide(num1, num2));

				}

			}
			Console.ReadKey();

		}

		public static int Add(int num1, int num2)
		{
			return num1 + num2;
		}

		public static int Subtract(int num1, int num2)
		{
			return num1 - num2;
		}

		public static int Multiply(int num1, int num2)
		{
			return num1 * num2;
		}

		public static int Divide(int num1, int num2)
		{
			return num1 / num2;
		}
	}
}
