// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;


namespace listing
{
    public class listing
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many student in your class? ");

            int studentcount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the name of the student: ");

            string[] students = new string[studentcount];

            for (int i = 0; i < studentcount; i++)
            {
                students[i] = Console.ReadLine();
            }

            Console.WriteLine("--------------");


            Array.Sort(students);


            for (int i = 0; i < studentcount; i++)
            {
                Console.WriteLine(students[i]);
            }


            // Wait before closing
            Console.ReadKey();
        }
    }
}