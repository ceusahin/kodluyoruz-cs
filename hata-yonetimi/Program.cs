using System;

namespace hata_yonetimi
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmis oldugunuz sayi: " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " Hata! Lutfen tamsayi giriniz.");
            }
            finally
            {
                Console.WriteLine("Islem tamamlandi!");
            }
        }
    }
}
