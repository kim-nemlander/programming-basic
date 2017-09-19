using System;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int number;
            Console.WriteLine("Please, enter a number; ");
            userInput = Console.ReadLine();
            bool isUserInputTrue =  int.TryParse(userInput,out number);

            if (isUserInputTrue == true)
            {
                if (number < 0)
                {
                    //Console.WriteLine("The number {0} {1} is negative", number, userInput );
                    //Console.WriteLine("The number " + number + " is negative", number);
                    Console.WriteLine($"The number {number} -> {userInput} is negative");
                }
                else if (number > 0)
                {
                    Console.WriteLine($"The number {number} -> {userInput} is positive");
                }
                else
                {
                    Console.WriteLine($"The number {number} -> {userInput} is neutral");
                }

            }
            else
            {
                Console.WriteLine($"You typed not number {userInput}");
            }

            Console.ReadKey();
        }
    }
}
