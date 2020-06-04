using System;
using System.Net.Sockets;

namespace Ders3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İŞLEMLER");
            Console.WriteLine("yapılmasını istediğiniz işlem için ilgili rakama basınız..");
            Console.WriteLine("1-TOPLAMA");
            Console.WriteLine("2-ÇIKARMA");
            Console.WriteLine("3-ÇARPMA");
            Console.WriteLine("4-BÖLME");
            Console.WriteLine("5-MOD ALMA");
            Console.WriteLine("6-YÜZDE ALMA");
            Console.WriteLine("Herhangi bir tuş ile oturumu sonlandır..");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1.sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Seçilen işlem:");
            //yalnızca rakam olarak kontrol sağladım
            char islem = Convert.ToChar(Console.ReadLine());
            try
            {
                if (islem == '1')
                {
                    Console.WriteLine(sayi1 + "+" + sayi2 + "=" + (sayi1 + sayi2));
                }
                else if (islem == '2')
                {
                    Console.WriteLine(sayi1 + "-" + sayi2 + "=" + (sayi1 - sayi2));
                }
                else if (islem == '3')
                {
                    Console.WriteLine(sayi1 + "x" + sayi2 + "=" + (sayi1 * sayi2));
                }
                else if (islem == '4')
                {
                    Console.WriteLine(sayi1 + "/" + sayi2 + "=" + (sayi1 / sayi2));
                }
                else if (islem == '5')
                {
                    Console.WriteLine(sayi1 + "mod" + sayi2 + "=" + (sayi1 % sayi2));
                }
                else if (islem == '6')
                {
                    Console.WriteLine(sayi1 + "%" + sayi2 + "=" + (sayi1 * sayi2 / 100));
                }
                else
                {
                    goto son;


                }
            }
            catch
            {
                Console.WriteLine("İşlem adımında hata oluştu!!");
            }

        son:
            Console.WriteLine("OTURUM SONLANDIRILDI..");


            Console.ReadKey();
        }
    }
}
