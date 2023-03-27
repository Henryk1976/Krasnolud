using System;

namespace Krasnolud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile masz wzrostu w cm ?");

            string x = Console.ReadLine();

            int a = int.Parse(x);

            if (a <= 140)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }
            else if (a > 140 && a < 160)
            {
                Console.WriteLine("grasz w Barcelonie"); 
            }
            else { Console.WriteLine("w dowodzie będziesz miał napisane 'wysoki'");
            }
        }
    }
}
