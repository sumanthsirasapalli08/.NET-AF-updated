namespace largest_of_3_numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int number1;
			int number2;
			int number3;

			Console.Write("enter number1 :");
			number1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("enter number2 :");
			number2 = Convert.ToInt32(Console.ReadLine());

			Console.Write("enter number3 :");
			number3 = Convert.ToInt32(Console.ReadLine());

			if (number1 > number2 && number1 > number3)
			{
				Console.WriteLine("largest number is " + number1);
			}
			else if (number2 > number3 && number2 > number1)
			{

				Console.WriteLine("largest number is " + number2);
			}
			else
			{
				Console.WriteLine("largest number is " + number3);
			}
			Console.ReadLine();
		}
	}
}

