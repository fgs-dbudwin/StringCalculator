using System;

namespace StringCalculator.Src
{
    public class StringCalculatorMain
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("String to Sum:");

                string number = Console.ReadLine();

                Calculator calculator = new Calculator();

                int sum = calculator.Add(number);

                Console.WriteLine("Sum of Numbers: " + sum);
            }
        }
    }
}
