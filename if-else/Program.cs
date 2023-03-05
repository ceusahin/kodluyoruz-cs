using System;

namespace if_else
{
    class Program
    {
        public static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            
            if(time >= 6 && time <= 12)
            {
                Console.WriteLine("Good Morning!");
            }
            else if(time > 12 && time <= 18)
            {
                Console.WriteLine("Have a good day!");
            }
            else
            {
                Console.WriteLine("Have a good night!");
            }

            // string sonuc = time <= 18 ? "Good Morning!" : "Good Evening!";
            string sonuc = time >= 6 && time <= 12 ? "Good Morning!" : time > 12 && time <= 18 ? "Have a good day!" : "Have a good night!";
            Console.WriteLine(sonuc);
        }
    }
}
