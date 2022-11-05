// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace My_programe
{
    public class Programe
    {

        static void Main(string[] args)
        {
            Console.Write("How many times you want your number to sqaure? ");

            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }

            // for (int i = 10; i < 0; i--)
            // {
            //     Console.Write(i);
            // }
        }

    }


}