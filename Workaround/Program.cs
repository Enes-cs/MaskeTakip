using Business.Concrete;
using Entities.Concrete;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Ctrl + R + M Methodlama
            //Ctrl + K + C Commentleme
            //Ctrl + K + U Uncomment
            //Ctrk + K + D Satırları Düzeltme

            SelamVer("Enes");
            SelamVer("Öznur");
            SelamVer();

            int sonuc = Topla(6, 58);

            //Diziler / Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Engi2";
            string ogrenci3 = "Engi3";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Enes";
            ogrenciler[2] = "İlker";

            ogrenciler = new string[4];
            ogrenciler[3] = "Süleyman";

            for (int i = 0; i < ogrenciler.Length; i++) //i++ = i=i+1
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new string[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new string[] { "Bursa", "Antalya", "Diyarbakır" };
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            foreach (var sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }
            //Diziler Sonu


            //Generic Collection
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir1" };
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }
            //Generic Collection Sonu

            //MyList
            MyListBase<string> liste = new MyListBase<string>();
            liste.Add("Enes");
            liste.Add("Enes2");
           
            liste.Check();
            Console.WriteLine(liste.AdCount);
            //MyList Sonu

            Person person1 = new Person();
            person1.FirstName = "İbrahim Enes";
            person1.LastName = "ÖZBAY";
            person1.DateOfBirthYear = 1995;
            person1.NationalIdentity = 627922222;

            Person person2 = new Person();
            person2.FirstName = "Taha İlker";
            person2.LastName = "KOÇ";
            person2.DateOfBirthYear = 1994;
            person2.NationalIdentity = 15485248;


            PttManager pttManager = new PttManager(new PersonManager());               
            pttManager.GiveMask(person1);
            pttManager.GiveMask(person2);


        }
        //Vatandas vatandas1 = new Vatandas();
        
        //resharper
        static void SelamVer(string isim = "isimsiz") //Git bunu yap = void
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10) //Hesapla çevir = int
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }

        /*private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 1110.0;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Enes";
            string soyad = "Özbay";
            int dogumYili = 1995;
            long tcNo = 62792020354;

            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);
        }
    }

	public class Vatandas
	{
        //Public proplar büyük harfle başlar
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set;} */

    }
}
