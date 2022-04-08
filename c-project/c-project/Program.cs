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

            
            
            */




            // 1) 2010 ile 2022 arasında mesai saatleri içerisinde(09:00 - 18:00) 1000 adet RANDOM TARİH oluştur ve bir tarih listesine ata


            List<DateTime> dateTimes = new List<DateTime>();
            int top = 0;

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
            // 2) Bu listede cumartesi ve pazar olmasın! //listemizin tamamından cumartesi ve pazarı cıkarıyoruz.RemoveAll()
            dateTimes.RemoveAll(x => x.DayOfWeek != DayOfWeek.Saturday && x.DayOfWeek != DayOfWeek.Monday);


            //3) Bu listenin içerisinde tarihlerin kaçı şubat ayı içerisindedir?
            //list içinden hepsini secip ay olanlardan kaçtanesi şubat demektir.

            dateTimes.FindAll(x => x.Month == 2).Count();

            //4) Bu listenin içerisindeki tarihlerin kaçı 12:00(öğlen) den öncedir. listede yer bulmak icin where() metodu kullanıyoruz. kaçı dediği için list yapısı sayac count();
            dateTimes.Where(x => x.Hour < 12).Count();


            //5) Bu listede kaç tane pazartesi var? //haftanın günlerinden pazar olanları secip sayac ile tuttuk.
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

            //6) Saat aralığı 17:00 - 18:00 arasında olan tüm tarihleri ekrana yaz. (Yapamadım)


            //7) Kullanıcı ekrandan bir yıl girsin ve o yıla ait tüm tarihleri ekrana yaz.(Yapamadım)

            //8) Kullanıcı ekrandan önce yıl sonra ay girsin ve bu ay ve yıla ait tüm tarihler sıralansın. Ekrandan yıl ve ay alıp yeni list içine eski listemizden yıl ve ayı for icinde cekip ekrana verdiö

            Console.WriteLine("Yılı gir.");
            int yıl = Convert.ToInt32(Console.Read());
            Console.WriteLine("Ayı gir.");
            int ay = Convert.ToInt32(Console.Read());
            List<DateTime> yeni = dateTimes.Where(x => x.Year == yıl && x.Month == ay).ToList();
            for (int i = 0; i < yeni.Count; i++)
            {
                Console.WriteLine("dddd.dd.MMMM:mm", CultureInfo.CurrentCulture);

            }

            // 9) 2010 SONRASI tarihleri ekrana yazdır.datetimes icindeki yıllardan 2010'dan büyükleri listeye atıp ekranda verdik

            List<DateTime> yeni2 = dateTimes.Where(x => x.Year > 2010).ToList();
            for (int i = 0; i < yeni2.Count; i++)
            {
                Console.WriteLine(yeni2.ToString("dddd.dd.MMMM.HHHH:mm", CultureInfo.CurrentCulture));
            }


            //10) 2010 - 2015 arasında SADECE OCAK ayında geçen tarihleri ekrana yazdır.yeni listemize eski listemizden 2010 ve 2015den büyükleri getirip ocak ayında olanları listeye atıp for ile ekrana verdim


            List<DateTime> yeni3 = dateTimes.Where(x => x.Year>=2010 && x.Year <=2015 && x.Month == 1);
            for (int i = 0; i < yeni3.Count; i++)
            {
                Console.WriteLine(yeni3.ToString("dddd.dd.MMMM.HHH:mm", CultureInfo.CurrentCulture));
            }
                

            


        }
    }

    

