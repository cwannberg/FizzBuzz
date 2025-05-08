namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine(); 
            string[] numbers = userInput.Split();

            int x = int.Parse(numbers[0]);
            int y = int.Parse(numbers[1]);
            int n = int.Parse(numbers[2]);

            for (int i = 1; i <= n; i++)
            {
                if (i % x == 0 && i % y == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % x == 0)
                    Console.WriteLine("Fizz");
                else if (i % y == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}