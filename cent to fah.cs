namespace session1_cent_to_fahren
{
	
		class Program
		{
			static void Main(string[] args)
			{
				int centigrade;
				double fahrenheit;

				Console.WriteLine("enter the centigrade:");
				centigrade = Convert.ToInt32(Console.ReadLine());

				fahrenheit = (centigrade * 1.8) + 32;
				Console.WriteLine("fahrenheit " + fahrenheit);
			        Console.ReadLine();
			


			}
		}
}
