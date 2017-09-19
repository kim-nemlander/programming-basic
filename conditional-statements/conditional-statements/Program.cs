using System;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Please, enter a number; ");
            number = int.Parse(Console.ReadLine());
            {
                if (number < 0)
                {
                    //Console.WriteLine("The number {0} {1} is negative", number, userInput );
                    //Console.WriteLine("The number " + number + " is negative", number);
                    Console.WriteLine($"The number {number} is negative");
                }
                else if (number > 0)
                {
                    Console.WriteLine($"The number {number} is positive");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"The number {number} is neutral");
                    Console.ReadLine();
        }
    }
}
