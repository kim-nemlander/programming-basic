using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool check;
            do
            {
                Console.WriteLine("Please, enter a number:");
                check = int.TryParse(Console.ReadLine(), out number);
            }
            while (!check);

            if (number % 2 == 0)
                
                Console.WriteLine($"The number {number}, is an even number.");

            else
                
                Console.WriteLine($"The number {number}, is an odd number.");
                
                Console.ReadLine();
        }
    }
}
