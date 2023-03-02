using System;

namespace console_programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("First name: ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Surname: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Welcome! " + name + " " + surname);

        }
    }
}
