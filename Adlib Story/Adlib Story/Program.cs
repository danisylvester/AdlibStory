using System;

namespace Adlib_Story
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("WELCOME TO MADLIBS!");
            Console.WriteLine("Mad Libs are interactive stories that you add your OWN words to.");
            Console.WriteLine("................................................");
            Console.WriteLine("Before we begin, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("................................................");
            Console.WriteLine($"It's great to meet you {name}! Now let's begin.");
            Console.WriteLine("................................................");

            Console.WriteLine("Please type an adjective.");
            string reply1 = Console.ReadLine();

            Console.WriteLine("Now, type a noun");
            string reply2 = Console.ReadLine();

            Console.WriteLine("Now, type another adjective.");
            string reply3 = Console.ReadLine();

            Console.WriteLine("Type another noun.");
            string reply4 = Console.ReadLine();

            Console.WriteLine("Type one last noun!");
            string reply5 = Console.ReadLine();

            Console.WriteLine("All right, it's now time to reveal your story!");

            Console.WriteLine("................................................");

            Console.WriteLine($"Learning to code can be fun if you follow this {reply1} advice when creating a method.");
            Console.WriteLine($"Always use the {reply2} naming convention.");
            Console.WriteLine($"Don't forget to include your {reply3} return type!");
            Console.WriteLine($"Access modifiers define the {reply4} of your method.");
            Console.WriteLine($"Of course, the {reply5} is the most important part of your method! ");


        }
    }
}
