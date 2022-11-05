// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace Calculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            double value1; // Either define datatype and variable on the top and use varieble down//
            double value2;
            double value3;

            Console.Write("Please enter value1: ");

            value1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter value2: ");

            value2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter value3: ");

            value3 = Convert.ToDouble(Console.ReadLine());

            double result = value1 + value2 + value3;

            double newResult = result / 3;

            Console.WriteLine($"The average of all three values are: {newResult} ");


        }
    }

}