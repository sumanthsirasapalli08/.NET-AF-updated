namespace factorial
{
	class Program
	{
		static void Main(string[] args)
		{
			int number, fact = 1, i;
			Console.WriteLine("enter number :");
			number = Convert.ToInt32(Console.ReadLine());
			for (i = 1; i <= number; i++)
			{
				fact = fact * i;
			}
			Console.WriteLine("factorial of a number :" + fact);
			Console.ReadLine();


		}
	}
}