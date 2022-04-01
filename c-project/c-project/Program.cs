using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_project
{
    class Program
    {
        static void Main(string[] args)
        {
            #region soru1
            /*
            //Soru-1 Ekrana 10 kez "Hello world" yazdır.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello World");
            }
            */
            #endregion
            #region soru2
            /*
            //2) Dışarıdan girilen sayıya kadar olan çift sayıları ekrana yazdır. Örneğin 11 girdiyse ekrana “2”,”4”,”6”,”8” gibi.
            Console.WriteLine("Bir Sayı Giriniz..");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < sayi; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */
            #endregion
            #region soru3
            /*
            //3) Dışarıdan girilen bir sayının rakamlarını tersine çeviren program.Örneğin 123 girdiyse ekrana 321 yazsın gibi.


            int sayi;
            int tersorakam;
            Console.Write("Sayiyi giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayinin tersi : ");
            while (sayi > 10)
            {
                tersorakam = sayi % 10;
                Console.Write(tersorakam);
                sayi /= 10;
            }
            Console.WriteLine(sayi);
            */
            #endregion
            
            //4) Verilen tamsayının sıfır, pozitif ya da negatif olup olmadığını bulan program.
            Console.WriteLine("Bir tam sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("Sayımız Pozitif");
            }
            else if (sayi == 0)
            {
                Console.WriteLine("Sayımız sıfıra eşittir");
            }
            else
            {
                Console.WriteLine("Sayımız negatif");
            }

            Console.ReadKey();
}
}
}
