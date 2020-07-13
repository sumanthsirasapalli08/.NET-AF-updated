
namespace exchange_values
{
	class Program
	{
		static void Main(string[] args)
		{
			double number1;
			double number2;
			double temp;
			
			Console.WriteLine("enter the  first number :");
			number1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("enter the second number :");
			number2 = Convert.ToDouble(Console.ReadLine());

			temp = number1;
			number1 = number2;
			number2 = temp;


			Console.WriteLine("After exchanging: ");
			Console.WriteLine(" number1 is :" + number1);
			Console.WriteLine(" number2 is :" + number2);
			Console.ReadLine();

		}
	}
}