using System;
using System.Reflection.Metadata.Ecma335;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome!");
            Console.WriteLine();
            Console.WriteLine("Glad that you are using my calculator!");
            Console.WriteLine();

            Console.WriteLine("Enter your first number");
            int numberOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Now choose from the provided operations, which are: '+', '-', '*', '/' ");
            char sum = '+';
            char minus = '-';
            char multiply = '*';
            char division = '/';

            char charInput = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int numberTwo = int.Parse(Console.ReadLine());

            numberTwo = CheckNumIfZero(division, charInput, numberTwo); // This method makes sure that numberTwo is always >0 or <0, but never 0;

            int result = 0;

            result = CalculatingRealNums(numberOne, sum, minus, multiply, division, charInput, numberTwo, result);

            Console.WriteLine($"Your result is: {result}");
            Console.WriteLine();
            Console.WriteLine("All rights stolen@ _|_");
            Console.WriteLine("2023");

        }

        public static int CalculatingRealNums(int numberOne, char sum, char minus, char multiply, char division, char charInput, int numberTwo, int result)
        {
            if (charInput == sum)
            {
                result = numberOne + numberTwo;
            }
            if (charInput == minus)
            {
                if (numberOne > numberTwo && numberTwo < 0)
                {
                    result = numberTwo - numberOne + numberOne + numberOne;
                }
                else
                {
                    result = numberOne - numberTwo;
                }
            }
            if (charInput == multiply)
            {
                result = numberOne * numberTwo;
            }
            if (charInput == division)
            {
                result = numberOne / numberTwo;
            }

            return result;
        }

        public static int CheckNumIfZero(char division, char charInput, int numberTwo)
        {
            if (numberTwo == 0 && charInput == division)
            {

                Console.WriteLine("Cannot divide by 0.");
                Console.WriteLine("Choose another number");

                numberTwo = int.Parse(Console.ReadLine());

                while (numberTwo == 0)
                {
                    Console.WriteLine("Cannot divide by 0.");
                    Console.WriteLine("Choose another number");
                    numberTwo = int.Parse(Console.ReadLine());
                }
            }

            return numberTwo;
        }
    }
}
