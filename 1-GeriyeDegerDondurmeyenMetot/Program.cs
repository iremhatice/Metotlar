namespace _1_GeriyeDegerDondurmeyenMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EkranaYaziYaz();
            RastgeleSayiOlusturma();
            DaireTemizligiSirasi();
            KarakterUzunlugu();
            EkranaIsımYaz("irem", 25);
            AlinanUrun(150,50);

        }

        #region Metot Kullanimi
        //ErişimBelirleyicisi(Public-Private) Niteleyici(Varsa)(Static)  DonusTipi(Void-String,Int,double..) MetotAdi (Parametre(Varsa))
        //{
        //Metot çağırıldığı zaman çalışacak kodlar.
        //}

        //-> Metot Çağırma
        //MetotAdi(Parametre(Varsa));

        //1) Erişim Belirleyicisi(Access Modifier): Metot'a kullanım yetkisi verme.Private: bu metodu sadece bu sınıf içerisinde kullanabilirsin. Public: bu metodu projenin herhangi bir yerinde kullanabilirsin anlamı taşır.

        //2) Niteleyici(static): Static anahtar kelimesini kısaca açıklamak gerekirse oluşturduğumuz metodu bellekte sabit hale getirir.

        //3) Dönüş Tipi: Metodun çalışması sonucu kendisinin bir bilgi verip vermeyeceğini belirlediğim yerdir.Eğer bir bilgi döndüreceksek,int,string,double gibi değerler alacak.Geriye değer döndürmeyecekse "void" anahatar kelimesi yazılır.

        //4) Metot Ismi: metot çağrılırken kullanılacak isimdir.

        #endregion

        //Geriye değer döndürmeyen Parametresiz metot
        private static void EkranaYaziYaz()
        {
            //Çalıştırılacak kodlar
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Merhaba Dünya");
            Console.BackgroundColor = ConsoleColor.Black;

        }

        #region Geriye değer döndürmeyen Parametresiz metot

        #region Ornek 1

        //Ekrana rastgele 5 tane sayi yazdiran metot olusturunuz.
        static void RastgeleSayiOlusturma()
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sayi: " + rnd.Next());
            }
        }
        #endregion

        #region Ornek 2
        //5 adet dairenin temizligini sirasiyla yapan metot olusturunuz. (1. kat temizligi yapildi)
        static void DaireTemizligiSirasi()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}. kat temizliği yapıldı");
            }
        }

        #endregion

        #region Ornek 3

        //Ekrana "bir gün her şey daha güzel olacak" cümlesinin karakter uzunlugu kadar ekranda cumleyı yazdırınız.
        static void KarakterUzunlugu()
        {
            string metin = "bir gün her şey daha güzel olacak";
            for (int i = 0; i < metin.Length; i++)
            {
                Console.WriteLine(metin);
            }
        }
        #endregion

        #endregion

        //Geriye değer döndürmeyen Parametreli metot
        static void EkranaIsımYaz(string isim, int yas)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(isim);
            Console.WriteLine("Yaş: " + yas);
            Console.ForegroundColor = ConsoleColor.White;
        }

        #region Geriye değer döndürmeyen Parametreli metot

        #region Ornek 1
        static void SayilarinToplami(int sayi)
        {
            int tektoplam = 0, çifttoplam = 0;
            for (int i = 0; i <= sayi; i++)
            {
                if (i % 2 == 0)
                {
                    çifttoplam += i;
                }
                else
                {
                    tektoplam += i;
                }

            }
            Console.WriteLine($"Çift sayıların toplamı {çifttoplam} ");
            Console.WriteLine($"Tek sayıların toplamı {tektoplam}");
        }

        #endregion

        #region Ornek 2
        //Gonderilen sayının karesini ekrana yazdiriniz.
        static void KaresiAlma(double sayi)
        {
            Console.WriteLine("Karesi: " + sayi * sayi);
        }
        #endregion

        #region Ornek 3
        //Gonderilen metnin iceriginde gonderilen kelime geciyormu yazdiriniz.
        static void MetinKontrol(string metin, string ikincimetin)
        {
            bool kontrol = metin.Contains(ikincimetin);
            Console.WriteLine(kontrol);
        }
        #endregion

        #region Ornek 4
        //Bir meyve dizisi alan ve her meyveyi uzunlugu kadar tekrarlı yazdıran metot olusturunuz.
        static void MeyveDizisi(string[] meyveler)
        {

            for (int i = 0; i < meyveler.Length; i++)
            {
                Console.WriteLine("\n" + meyveler[i] + "\n");
                for (int j = 0; j < meyveler[i].Length; j++)
                {
                    Console.WriteLine("*" + meyveler[i]);
                }
            }
        }
        #endregion

        #region Ornek 5
        //Disaridan alinan karakterler, adet, uzunluk bilgisine gore ekranda rastgele ilgili uzunlukta ilgili adet kadar ifadeyi yazan metot olusturunuz.
        static void RastgeleIsimOlustur(string karakterler, int adet, int uzunluk)
        {
            Random random = new Random();

            for (int i = 0; i < adet; i++)
            {
                string rastgeleIsim = "";
                for (int j = 0; j < uzunluk; j++)
                {
                    int index = random.Next(karakterler.Length);
                    rastgeleIsim += karakterler[index];
                }
                Console.WriteLine(rastgeleIsim);
            }
        }
        #endregion

        #region Ornek 6
        //Bir tamsayi listesi alan ve bu tamsayilarin karelerini ekrana yazan metot olusturunuz.
        static void Liste(List<int> sayilar)
        {
            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i] * sayilar[i]);
            }

        }
        #endregion

        #region Ornek 7 
        //Disaridan alinan bir urunun eski fiyatini ve zaman oranina gore yeni fiyatini ekranda yazdiran metot olusturunuz.
        static void AlinanUrun(decimal eskiFiyat, decimal zamOrani)
        {
            decimal yeniFiyat = eskiFiyat + (eskiFiyat * zamOrani / 100);
            Console.WriteLine("Yeni Fiyat: " + yeniFiyat);
        }
        #endregion

        #endregion

    }
}
