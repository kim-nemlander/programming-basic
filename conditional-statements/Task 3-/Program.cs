using System;

namespace Task_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool check = true;
            do
            {
                if (check)
                    Console.WriteLine("Please, enter a number:");
                else
                    Console.WriteLine("That's not a number, please enter a number:");
                check = int.TryParse(Console.ReadLine(), out number);

            }
            while (!check);
            {
                if (number < 0)
                    Console.Write($"The number {number} is negative ");
                else if (number > 0)
                    Console.Write($"The number {number} is positive ");         
                else
                    Console.Write($"The number {number} is neutral ");

                if (number % 2 == 0)
                    Console.WriteLine($"and it is an even number.");
                else
                    Console.WriteLine($"and it is an odd number.");

            }
            Console.ReadKey();
        }
    }
}
