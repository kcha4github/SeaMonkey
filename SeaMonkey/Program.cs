using System;

namespace SeaMonkey
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Hello {Environment.UserName}! This is the Monkey programming language!");
            Console.WriteLine("Feel free to type in commands");

            Repl.Repl.Start(Console.In, Console.Out);
        }
    }
}
