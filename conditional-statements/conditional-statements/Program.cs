using System;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            {
                Console.WriteLine("Please, enter a number:");
            }
            bool check;
            do
            {
                Console.WriteLine("Please, enter a number:");
                check = int.TryParse(Console.ReadLine(), out number);
            }
            while (!check);
            if (number < 0)
                {   
                    Console.WriteLine($"The number {number} is negative.");
                }
            else if (number > 0)
                {
                    Console.WriteLine($"The number {number} is positive.");
                }
            else
                {
                    Console.WriteLine($"The number {number} is neutral.");
                }
            Console.ReadLine();
        }
    }
}
