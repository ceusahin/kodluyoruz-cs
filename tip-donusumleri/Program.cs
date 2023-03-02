using System;

namespace tip_donusumleri
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Implicit Donusum (Bilincsiz)
            Console.WriteLine("**** Implicit ****");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("int: " + d);

            long h = d;
            Console.WriteLine("long: " + h);

            float i = h;
            Console.WriteLine("float: " + i);

            string e = "hakan";
            char f = 's';
            object g = e + f + d;
            Console.WriteLine("object: " + g);

            // Explicit Donusum (Bilincli)
            Console.WriteLine("**** Explicit ****");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("byte: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("byte2: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("byte3: " + v);

            // To.String
            Console.WriteLine("**** To.String ****");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine(yy);

            string zz = 12.5f.ToString();
            Console.WriteLine(zz);

            // System.Convert 
            Console.WriteLine("**** System.Convert ****");

            string s1 = "10", s2 = "20";
            int sayi1, sayi2, sum;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            sum = sayi1 + sayi2;

            Console.WriteLine("Toplam: " + sum);

            // Parse
            Console.WriteLine("**** Parse ****");

            string metin1 = "25";
            string metin2 = "25,3";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("rakam1: " + rakam1);
            Console.WriteLine("rakam2: " + double1);
        }
    }
}