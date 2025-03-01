namespace _2_GeriyeDegerDondurenMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            RastgeleSayilardanOlusanListe();
            CiftSayi();
            IsımDondur();
            AdSoyadBirlesimi("irem", "kars");
            Info("irem", 25);
            Bolum(4, 2);
            KullaniciKontrol("irem","123");
        }

        #region Geriye deger donduren parametre almayan metot

        //return: Geriye deger dondurmeyen metotlarda da kullanilan amaci metodu kesmek olan bu anahtar kelime geriye deger dondurenlerde onune yaziln degeri dondurmektedir.

        static List<int> RastgeleSayilardanOlusanListe()
        {
            Random rnd = new Random();
            List<int> ints = new List<int>();
            for (int i = 0; i < 10; i++)
                ints.Add(rnd.Next(10));
            return ints;
        }
        #endregion

        #region  Ornek 1 
        //Kullaniciya [0-100] arasinda rastgele cift bir sayi donen metot olusturunuz.
        static int CiftSayi()
        {
            Random rnd = new Random();
            while (true)
            {
                int sayi = rnd.Next(0, 100);
                if (sayi % 2 == 0) return sayi;
            }
        }
        #endregion

        #region Ornek 2 
        //Rastgele bir isim donduren metot olusturunuz.
        static string IsımDondur()
        {
            string[] names = { "irem", "mert", "eren", "milena" };
            Random rnd = new Random();
            int index = rnd.Next(names.Length);
            return names[index];
        }
        #endregion

        #region Ornek 3 
        //Rastgele uretilen 5 sayidan en buyugunu donen metot olusturunuz.
        static int EnBuyukSayi()
        {
            List<int> integerlar = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                integerlar.Add(rnd.Next(100));
            }

            int enBuyuk = integerlar[0];

            foreach (var item in integerlar)
            {
                enBuyuk = Math.Max(item, enBuyuk);
            }
            return enBuyuk;
        }
        #endregion

        #region Geriye deger donduren parametre alan metot
        //Ad soyad alip geriye tek bir string ifade olarak donen metot olusturunuz.
        static string AdSoyadBirlesimi(string ad, string soyad)
        {
            return $"{ad} {soyad}";
        }
        #endregion

        #region Ornek 1
        //Adini ve dogum tarihini alarak adinin yaninda yasini yazip gonderen metot olusturunuz.
        static string Info(string ad, int dogumYili)
        {
            int yas = 2025 - dogumYili;
            return $"{ad} {yas} yasindadir.";
        }
        #endregion

        #region Ornek 2
        //Disaridan iki sayi alip buyugu kucuge bolen metot olusturunuz. Eger deger gelemzse 0'ı 1'e bolebilelim.
        static int Bolum(int sayi1 = 0, int sayi2 = 1)
        {
            int enBuyuk = Math.Max(sayi1, sayi2);
            int enKucuk = Math.Min(sayi1, sayi2);
            int bolum = enBuyuk / enKucuk;
            return bolum;
        }
        #endregion

        #region Ornek 3
        //Kullanici adi ve parola kontrolu yapip geriye true veya false olarak donen metot olusturunuz.
        static string KullaniciKontrol(string kullanici, string parola)
        {
            if (kullanici == "admin" && parola == "123") return "true";
            else return "false";
        }
        #endregion

        #region Ornek 4
        //Gonderilen  3 adet sayidan en buyugu ile en kucugu arasindaki mesafeyi donen metot olsuturunuz.
        static double MesafeHesabi(double sayi1, double sayi2, double sayi3)
        {
            double enBuyukSayi = Math.Max(sayi1, Math.Max(sayi2, sayi3));
            double enKucukSayi = Math.Min(sayi1, Math.Min(sayi2, sayi3));
            return enBuyukSayi - enKucukSayi;
        }
        #endregion

        #region  Ornek 5 
        //Gonderilen metinsel ifade tam sayiya donusturelebiliyormu dönüstürelemiyormu cevabini donen metot olusturunuz.
        static bool MetinselIfade(string ifade)
        {
            bool donusturulme = int.TryParse(ifade, out int sayi);
            if (donusturulme) return donusturulme;
            else return false;
        }

        #endregion
    }
}
