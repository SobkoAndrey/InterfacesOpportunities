using System;

namespace InterfacesOpportunities
{

	interface IMath1
	{
		int Addition(int firstOperand, int secondOperand);
		int Subtraction(int firstOperand, int secondOperand);
	}

	interface IMath2 : IMath1
	{
		int Divide(int firstOperand, int secondOperand);
		int Multiplication(int firstOperand, int secondOperand);

	}

	interface IIndex : IMath2
	{
		int this[int index]
		{
			get;
		}
	}

	class MathClass : IIndex
	{
		int value;

		public int this[int index]
		{
			get
			{
				value = 0;
				for (int i = 0; i < index; i += 1)
					value += 3;
				return value;
			}
		}

		public int Addition(int a, int b)
		{
			Console.WriteLine(a + b);
			return a + b;
		}

		public int Subtraction(int a, int b)
		{
			Console.WriteLine(a - b);
			return a - b;
		}

		public int Divide(int a, int b)
		{
			Console.WriteLine(a / b);
			return a / b;
		}

		public int Multiplication(int a, int b)
		{
			Console.WriteLine(a * b);
			return a * b;
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			MathClass math = new MathClass();

			Console.WriteLine("Addition of 3, 2");
			math.Addition(3, 2);

			Console.WriteLine("Subtraction of 3, 2");
			math.Subtraction(3, 2);

			Console.WriteLine("Divide of 10, 2");
			math.Divide(10, 2);

			Console.WriteLine("Multiplication of 3, 2");
			math.Multiplication(3, 2);

			Console.WriteLine("Get value for index 6");
			Console.WriteLine(math[6]);
		}
	}
}
