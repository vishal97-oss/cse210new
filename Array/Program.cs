// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace Arrey
{
    public class Arrey
    {
        // static void Main(string[] args)
        // {   //This arrey is an example when we know before hand what we 
        //     //want in our arrey.
        //     string[] movies = { "Movie1", "Movie2", "Movie3", "Movie4" };
        //     // Arrey and for loop together
        //     for (int i = 0; i < movies.Length; i++)
        //     {
        //         int rank = i + 1; // This is rank variable is just to show the rank numbers.
        //         Console.WriteLine(rank + ". " + movies[i]);
        //         // The first time i is going to be 0 so our first movie
        //         // would be Movie1 and second time i is going to be
        //         // 1 so out movie is going to be Movie1 and so forth. 
        //     }
        // }

        static void Main(string[] args)
        {
            //Empty arrey which has a space of 5 movie name. 
            string[] movies = new string[5];

            Console.WriteLine("Type your five favroite movies: ");

            for (int i = 0; i < movies.Length; i++)
            {
                movies[i] = Console.ReadLine();
            }



            Console.WriteLine("\nHere is you movies: ");
            Array.Sort(movies);

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }
        }

    }
}