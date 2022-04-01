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
                    Console.WriteLine(i);    //for ile sayiya kadar gidip if  karar yapısıyla 2  bölümünden kalan sıfırsa çifttir.
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
            Console.Write("Sayinin tersi : ");                     // Hocam bu kod yapısını pek anlayamadım.Boş bırakmak istemedim.Tamamını netten buldum.
            while (sayi > 10)
            {
                tersorakam = sayi % 10;
                Console.Write(tersorakam);
                sayi =sayı / 10;
            }
            Console.WriteLine(sayi);
            */
            #endregion
            #region soru4
            /*
            //4) Verilen tamsayının sıfır, pozitif ya da negatif olup olmadığını bulan program.
            Console.WriteLine("Bir tam sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("Sayımız Pozitif..");
            }
            else if (sayi == 0)
            {                                                               //dışarıdan sayı alıp if karar yapısıyla kontrol edip ekrana bastık.
                Console.WriteLine("Sayımız sıfıra eşittir..");
            }
            else
            {
                Console.WriteLine("Sayımız negatif..");
            }
            */

            #endregion
            #region soru5
            /*
            // 5) Girilen fiyatın KDV li halini ( % 18 ) ekrana yazdır.
            double fiyat, kdv, toplam;
            Console.Write("Ürünün Fiyatını Giriniz..");
            fiyat = Convert.ToDouble(Console.ReadLine());           //dışarıdan ürün fiyatını alıp 0,18 ile carpıp kdvli halini eekrana  bastık.
            kdv = fiyat * 18 / 100;
            toplam = fiyat + kdv;
            Console.WriteLine("KDV :" + toplam.ToString());
            */

            #endregion
            #region soru6
            /*
            //6) Üniversite bir dersin başarı notu bir vize bir final sınav notu ile hesaplanır. Vize notunun kat sayısı %30 final notunun kat sayısı %70’dir. 
            //   Bir öğrencinin sınavda almış olduğu bu notlar neticesinde ders ortalaması bulun.
            Console.WriteLine("Vize giriniz..");
            double vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final giriniz..");                           //vize ve final notunu klavyeden alıp 0,3 0,7 ile  carpıp ekrana yazdırdık.
            double final = Convert.ToInt32(Console.ReadLine());
            double ort = vize * (0.3) + final * (0.7);
            Console.WriteLine("Notunuz: " + ort);
            */
            #endregion
            #region soru7
            /*
            //7) Kullanıcıdan alınan sayının tek ya da çift olduğunu kontrol edip ekranda yazdırın
            Console.WriteLine("Sayı Giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine(sayi + ":Sayımız çift..");
            }
            else                                                    //sayıyı if karar  yapısıyla kontrol edip ekrana  konsola verdik.
            {
                Console.WriteLine(sayi + " :Sayımız tek..");
            }
            */
            #endregion
            #region soru8
            /*
            //8) Bir kenar uzunluğu ve o kenara ait yüksekliği girilen üçgenin alanını hesaplayın.
            int ucgenA, taban, yukseklik;
            Console.WriteLine("Taban değeri giriniz.");
            taban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yukseklik değeri giriniz.");
            yukseklik = Convert.ToInt32(Console.ReadLine());
            //ucgen alanı (taban*yukseklik)/2                       //taban alanı  ve yüksekliği klavyeden alıp formüle göre ücgen alanını hesapladık.
            ucgenA = (taban * yukseklik) / 2;

            Console.WriteLine("Üçgenin alanı=" + ucgenA);
            */

            #endregion
            #region soru9
            /*
            //9) Girilen bir x sayısının yine girilen bir y sayısına tam bölünüp bölünmediğini ekrana yazdırın
            Console.WriteLine("Sayı giriniz:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı giriniz:");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x % y == 0)
            {
                Console.WriteLine("x sayısı y sayısına tam bölünebilir..");     //tam  bölünmesi için if karar yapısıyula bölümünden kalan yani(%) ile 0 eşit  olup olmadığını kontrol edip ekrana  verdik.
            }
            else
            {
                Console.WriteLine("x sayısı y sayısına tam bölünemez..");
            }
            */

            #endregion
            #region soru10
            /*
            //10) Çarpma operatörü kullanmadan klavyeden girilen sayının 5 katını bulun.
            int sayi1, sayi2, sonuc = 0;
            Console.Write("1. sayıyı giriniz : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 5; i++)
            {
                sonuc = sonuc + sayi1;                      //istediğimiz kat sayısı kadar (5)  for döngüsüyle dönüp sonuc degiskenine attık ve ekrana verdik.
            }
            Console.WriteLine("Çarpım Sonucu : " + sonuc);
            */
            #endregion
            #region soru11
            /*
            //11) Dışarıdan girilen N sayısına kadar olan asal sayıları bulan program
            int kontrol = 0;
            Console.Write("Sayı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            while (i < sayi)
            {
                if (sayi % i == 0)                  //hocam asal sayı rroblemini unutmusum while kısmını netten buldum.
                    kontrol++;
                i++;
            }

            if (kontrol != 0)
                Console.WriteLine("Girdiğiniz sayı asal değildir.");
            else
                Console.WriteLine("Girdiğiniz sayı asaldır.");
            */
            #endregion
            #region soru12
            /*
            //12) N elemanlı bir dizideki en küçük elemanı ve bu elemanın adresini (index no) bulan program.
            int[] dizi = new int[5];
            dizi[0] = 5;
            dizi[1] = 7;
            dizi[2] = 12;
            dizi[3] = 8;
            dizi[4] = 3;
           
            int enk = dizi[0];

            for (int i = 0; i < dizi.Length; i++)           //enk  degiskeni olusturup dizinin ilk elemanını en kücük yaptık sonra bir sonraki ile karsılastırıp yer degistirerek en kücük sayıyı bulduk ve   
            {                                                   //ve enk  bulduğumuz index yani i ekrana  verdik.

                if (dizi[i] < enk)
                {
                    enk = dizi[i];
                    Console.WriteLine("en kücük degerimiz " + enk + " indeks değeri:" + i);
                }
            }
            */
            #endregion
            #region soru13
            /*
            //13) N elemanlı bir diziyi yedek dizi KULLANMADAN tersine çeviren program.

            int[] dizi = { 5, 6, 9, 12, 22, 52, 11 };
            int gecici;

            for (int i = 0; i < dizi.Length / 2; i++)
            {
                gecici = dizi[i];
                dizi[i] = dizi[dizi.Length - i - 1];  //hocam bu soruyu boş bırakmak istemedim komple netten baktım herhangi  bir  fikir yüretemedim.
                                                                                            
                dizi[dizi.Length - i - 1] = gecici;
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            */
            #endregion
            #region soru14
            /*
            //14) Dışarıdan girilen bir cümledeki kelime sayısını bulan program.
            string metin;
            Console.Write("Metni Girin  : ");  //dışarıdan cümle isteriz
            metin = Console.ReadLine();
            string[] kelimeler = metin.Split(' '); //string dizisi olusturup kelime kelime string methotu ile(split)yapabilriz.
            Console.WriteLine("Kelime Sayısı :" + kelimeler.Length); //sonra kelime dizisinin index(length) ile sayısını buluruz.
            */

            #endregion
            #region soru15(yapılmadı)
            //15) Dışarıdan girilen en az 5 basamaklı sayının ilk ve son basamakları arasındaki sayıların toplamını bulan program..
            #endregion #region soru16
            #region soru16
            //16) Dışarıdan girilen sayının faktöriyelini hesapla
            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = 1;   //faktoriyelde 
            for (int i = sayi; i > 1; i--) //baslagıc sartını sayıdan baslatarak geriye dogru 1 1  azaltıp carpıp sonuc degiskenine atarız vee consoledan cıktı alırız.
            {
                sonuc = sonuc * i;
            }
            Console.Write("Faktöriyeli:" + sonuc);
            #endregion
            #region soru17(yapılmadı)
            /*
            17) Aşağıdaki formu ekrana yazdıran program.

1

2 3

4 5 6

7 8 9 10

11 12 13 14 15
*/
            #endregion
            #region soru18(yapılmadı)
            /*
            18) Aşağıdaki formu ekrana yazdıran program.

2 3 4 5 6

3 5 7 9 11

4 7 10 13 16

5 9 13 17 21

6 11 16 21 26
*/
            #endregion



            Console.ReadKey();
}
}
}
