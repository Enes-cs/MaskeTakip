namespace Workaround
{
    public class MyListBase<Ad> //MyListBase<Ad> adında bir generic sınıf tanımlamışsın.dizi içindeki elemanları yakalamak için
    {
        Ad[] isimler; //isimler adında bir dizi oluşturmuşsun. eklenen elemanları depolamak için.

        public MyListBase()  // constructor metot oluşturmuşsun 
        {
            isimler = new Ad[0]; // başlangıçda boş bir dizi olacağını söylemişsin.
        }
        
        public void Add(Ad ad)  // Add metodu  oluşturmuşsun. listeye eleman ekleyebilmek için
        {
            Ad[] _adtutucu = isimler; // contracture da tanımladığın diziyi korumak için aynı dizinin kopyasıyla isimler dizisinde oluşturmuşsun

            isimler = new Ad[_adtutucu.Length + 1]; // sonra dizinin noyutunu bir artırarak yeni dizi oluşturuyorsun

            for (int i = 0; i < _adtutucu.Length; i++) //döndürürken eşitleyerek değerleri tutucuda tutturdum
            {
                isimler[i] = _adtutucu[i]; //ordaki eleman da program cs de add metoduna yazdığın eleman gelip yerleşiyor.
            } //sonra bu _addtutucu dizindeki elemanlar isimler dizisine kopyalanır en son eklenen eleman da dizinin
              //son indexi olarak yerleşir yani (dizi 6 elemanlıysa son indexin 5 olacak 0. elemandan başlattığın için)

            isimler[isimler.Length - 1] = ad; //isimlerin 1 eksiğine yeni değer geldi
        }
        public int AdCount //AddCount metodunda da eleman sayısını yazdırmışsın
        {
            get { return isimler.Length; } 
        }
        public void Check() //Check metodunda da tüm listeyi yazdırmışsın get işlemi ile
        {
            for (int i = 0; i < isimler.Length; i++)
                Console.WriteLine(isimler[i]);
        }
    }
}
//program.cs de de new leyip referans oluşturup bi nevi set işlemi yaparak eleman ekliyorsun daha sonra eklediğin elemanları check metodunu çağırarak yazdırıyorsun konsola