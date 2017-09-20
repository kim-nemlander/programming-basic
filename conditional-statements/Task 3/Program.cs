using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberX, numberY, numberZ;
            Console.WriteLine("Please input three numbers");
            Console.Write("Please input the first number: ");
            numberX = int.Parse(Console.ReadLine());
            Console.Write("Please input the second number: ");
            numberY = int.Parse(Console.ReadLine());
            Console.Write("Please input the third number: ");
            numberZ = int.Parse(Console.ReadLine());

            if (numberX < numberY)
            {
                if (numberX < numberZ)
                {
                    if (numberY < numberZ)
                    {
                        Console.WriteLine($" {numberX} , {numberY} , {numberZ}");                   
                    }
                    else
                    {
                        Console.WriteLine($" {numberX} , {numberZ} , {numberY}");
                    }
                }
                else
                {
                    Console.WriteLine($" {numberZ} , {numberX} , {numberY}");
                }
            }
            else
            {
                if (numberX < numberZ)
                {
                    Console.WriteLine($" {numberY} , {numberX} , {numberZ}");
                }
                else
                {
                    if (numberY < numberZ)
                    {
                        Console.WriteLine($" {numberY} , {numberZ} , {numberX}");
                    }
                    else
                    {
                        Console.WriteLine($" {numberZ} , {numberY} , {numberX}");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
