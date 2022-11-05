// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace Themepark
{

    public class Themepark
    {

        static void Main(string[] args)
        {

            int age01;
            double height01;

            Console.Write("Please enter your age: ");
            age01 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please your height: ");
            height01 = Convert.ToDouble(Console.ReadLine());

            // if (age01 =< 18 && height01 =< 5.7)
            // {
            //     Console.WriteLine("You are to young to enter the Theme park");
            // }
            // else
            // {
            //     Console.WriteLine("Welcome to the ThemePark!");
            // }

            // if (age01 >= 18 && height01 >= 5.7)
            // {
            //     Console.WriteLine("Welcome to the Themepark!");
            // }
            // else
            // {
            //     Console.WriteLine("You are to young to enter the Theme park");
            // }

            if (age01 > 18 || height01 > 5.7) // Either one of the condition has ti meet //
            {
                Console.WriteLine("Welcome to the Themepark!");
            }
            else if (age01 == 1 && height01 == 1) //Has to meet both condition //

            {
                Console.WriteLine("You are still Welcome :) ");
            }
            else
            {
                Console.WriteLine("You are to young to enter the Theme park");
            }


        }
    }
}