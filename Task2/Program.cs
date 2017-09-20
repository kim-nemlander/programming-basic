using System;

namespace Task2
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

            if (number % 2 == 0)
                
                Console.WriteLine($"The number {number} is an even number");
                
            else
                
                Console.WriteLine($"The number {number} is an odd number");

                Console.ReadKey();
        }
    }
}
