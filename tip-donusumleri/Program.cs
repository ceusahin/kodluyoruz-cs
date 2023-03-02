using System;

namespace tip_donusumleri
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dt);
            Console.WriteLine(datetime1);
        }
    }
}