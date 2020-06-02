using System;

namespace Ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Klavyeden 2 sayı girilecek, girilen bu sayılara 4 işlem, yuzde ve modu gösteren programı yapınız.

            //Console.WriteLine("1.sayı=");
            //int sayi1=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayı=");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(sayi1 + "+" + sayi2+"=" + (sayi1 + sayi2));
            //Console.WriteLine(sayi1 + "-" + sayi2+"=" + (sayi1 - sayi2));
            //Console.WriteLine(sayi1 + "x" + sayi2 + "=" + (sayi1 * sayi2));
            //Console.WriteLine(sayi1 + "/" + sayi2 + "=" + (sayi1 / sayi2));
            //Console.WriteLine(sayi1 + "mod" + sayi2 + "=" + sayi1 % sayi2);
            //Console.WriteLine(sayi1 + "%" + sayi2 + "=" + (sayi1 * sayi2/100));

            //Console.WriteLine("------------------------------------");

            ////Atama İşlemleri
            //int x = 100;
            //int y = 50;
            //x++;
            //Console.WriteLine(x);
            //x += 2;
            //Console.WriteLine(x);
            //y /= 5;
            //Console.WriteLine(y);
            //x = (y += 1); //x=(y=y+1)  
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //Console.WriteLine("------------------------------------");

            //Console.WriteLine("Yaş=");
            //int yas=Convert.ToInt32(Console.ReadLine());
            //if(yas>0)
            //{
            //    if(yas>=18)
            //    {
            //        Console.WriteLine("Ehliyet Alabilirsiniz..");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ehliyet Alamazsınız!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Giriş..");
            //}

            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Kullanıcı Adı=");
            //string k_adi=Console.ReadLine();
            //Console.WriteLine("Şifre=");
            //string sifre = Console.ReadLine();
            //if (k_adi == "EbruSmnc" & sifre == "12345")
            //{
            //    Console.WriteLine("Başarılı Giriş..");

            //}
            //else
            //    Console.WriteLine("Hatalı Giriş!");

            Console.WriteLine("------------------------------------");

            Console.WriteLine("sayı=");
            int sayi=Convert.ToInt32(Console.ReadLine());
            if(sayi%2==0)
            {
                Console.WriteLine(sayi +"Çift Sayıdır..");
            }
            else
            {
                Console.WriteLine(sayi + "Tek Sayıdır..");
            }


            Console.WriteLine("------------------------------------");

            Console.ReadKey();
        }
    }
}
