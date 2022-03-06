using System;


namespace FizzBuzzEdzel
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Number: ");

            String userInput = Console.ReadLine();

            int x = int.Parse(userInput);

            for (int i = 1; i <= x; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

// code created by Edzel Mila BSIT-1