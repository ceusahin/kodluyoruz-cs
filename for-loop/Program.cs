using System;

namespace for_loop
{
    class Program
    {
        public static void Main(string[] args)
        {
            // print the numbers up to the entered number to the screen
            Console.Write("Prompt a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            // sums of odd and even numbers from 1 to 1000
            int oddSum = 0, evenSum = 0, sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i % 2 == 1)
                {
                    oddSum += i;
                }
                else
                {
                    evenSum += i;
                }
            }
            sum = oddSum + evenSum;
            Console.WriteLine("Sums of odd and even numbers from 1 to 1000: " + sum);
            
            // break, continue
            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("");

            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
