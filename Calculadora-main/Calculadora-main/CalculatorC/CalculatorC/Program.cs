using System;

namespace CalculatorC
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;

            Console.WriteLine("console calculator in c#/r");
            Console.WriteLine("---------------------n");

            Console.WriteLine("type a number and press enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Typer another number and press enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list ");
            Console.WriteLine("\ta - add ");
            Console.WriteLine("\ts - Substract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");

            switch (Console.ReadLine())
            {

                case "a":

                    Console.WriteLine($"Your result:  {num1}+ {num2}=" + (num1 + num2));
                    break;

                case "s":

                    Console.WriteLine($"Your result: {num1} - {num2}=" + (num1 - num2));
                    break;

                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2}=" + (num1 * num2));
                    break;
                case "d":

                    Console.WriteLine($"Your result: {num1} / {num2}=" + (num1 / num2));
                    break;

            }

            Console.Write("Pres any key to close the calculator app...");
            Console.ReadKey();
        }
    }
}
