using System;

namespace Adlib_Story
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("WELCOME TO MADLIBS!");
            Console.WriteLine("Mad Libs are interactive stories that you add your OWN words to.");
            Console.WriteLine("Before we begin, what is your name?");

            string name = Console.ReadLine();
            Console.WriteLine($"It's great to meet you {name}! Now let's begin.");

        }
    }
}
