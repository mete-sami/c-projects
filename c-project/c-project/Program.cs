using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace c_project
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            //Datetime, list, metot


            1) 2010 ile 2022 arasında mesai saatleri içerisinde(09:00 - 18:00) 1000 adet RANDOM TARİH oluştur ve bir tarih listesine ata

            2) Bu listede cumartesi ve pazar olmasın!

            3) Bu listenin içerisinde tarihlerin kaçı şubat ayı içerisindedir?

            4) Bu listenin içerisindeki tarihlerin kaçı 12:00(öğlen) den öncedir

            5) Bu listede kaç tane pazartesi var?

            6) Saat aralığı 17:00 - 18:00 arasında olan tüm tarihleri ekrana yaz.

            7) Kullanıcı ekrandan bir yıl girsin ve o yıla ait tüm tarihleri ekrana yaz

            8) Kullanıcı ekrandan önce yıl sonra ay girsin ve bu ay ve yıla ait tüm tarihler sıralansın.

            9) 2010 SONRASI tarihleri ekrana yazdır.

            10) 2010 - 2015 arasında SADECE OCAK ayında geçen tarihleri ekrana yazdır.
            */

            


            // 1) 2010 ile 2022 arasında mesai saatleri içerisinde(09:00 - 18:00) 1000 adet RANDOM TARİH oluştur ve bir tarih listesine ata


            List<DateTime> dateTimes = new List<DateTime>();


            for (int i = 0; i < 1000; i++)
            {
                //Yeni oluşturacağım tarihin YILI, AYI, GÜNÜ ve SAATİ RANDOM OLMAK ZORUNDA;

                Random rnd = new Random();

                int randomYear = rnd.Next(2010, 2023);
                int randomMonth = rnd.Next(1, 13);
                int randomDay = rnd.Next(1, 28);
                int randomHour = rnd.Next(9, 19);
                int randomMinute = rnd.Next(0, 60);

                DateTime newDate = new DateTime(randomYear, randomMonth, randomDay, randomHour, randomMinute, 0);

                dateTimes.Add(newDate);
            }

            int top = 0;
            for (int i = 0; i < dateTimes.Count(); i++)
            {
                if (dateTimes[i].DayOfWeek == DayOfWeek.Monday)
                {
                    top++;
                }
                Console.WriteLine(top);
                Console.ReadLine();
            

            }


        }
    }
}
    

