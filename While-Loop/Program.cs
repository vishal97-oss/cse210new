// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace Whileloop
{
    public class Whileloop
    {
        static void Main(string[] args)
        {
            Random numGen = new Random();

            int roll1 = 0;
            int roll2 = 0;
            int attemps1 = 0;

            Console.WriteLine("Please enter to Roll the dice ");

            while (roll1 != 6 || roll2 != 6)
            {
                Console.ReadKey();

                roll1 = numGen.Next(1, 7); // First number is minimum number (inclusive value) and second is maximum (exclusive value)
                roll2 = numGen.Next(1, 7);

                Console.WriteLine($"Roll 1: {roll1}  ");
                Console.WriteLine($"Roll 2: {roll2}  ");
                attemps1++; //Everytime it loops increase attemps by 1

            }
            Console.WriteLine($"Total attemps were: {attemps1} ");

        }
    }
}