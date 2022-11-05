// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace tickets
{
    public class tickets
    {
        static void Main(string[] args)
        {

            Console.Write("Welcome! tickets are $5 pleaae enter cash: ");
            // Either use data type and variable on the sameline //
            int cash = Convert.ToInt32(Console.ReadLine());

            if (cash < 5)
            {
                int leftover = 5 - cash;
                Console.WriteLine($"You have paid {cash} dollars and you are left with {leftover} more dollars");
            }
            else if (cash == 5)
            {
                Console.Write("Here is your tickets!");
            }
            else
            {
                int change = cash - 5;

                Console.WriteLine($"Here is your tickets and your {change} dollars change");
            }

        }
    }
}