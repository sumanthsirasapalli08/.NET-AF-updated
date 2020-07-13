namespace sum_of_digits
{
	class Program
	{
		static void Main(string[] args)
		{
			int number, sum = 0, rem;
			number = Convert.ToInt32(Console.ReadLine());
		        Console.WriteLine("enter the number :");

			while (number > 0)
			{
				rem = number % 10;
				sum = sum + rem;
				number = number / 10;
			}
			Console.WriteLine("sum of digits is :" + sum);
			Console.Read();

		}
	}
}
