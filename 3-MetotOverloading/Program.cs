namespace _3_MetotOverloading
{
    internal class Program
    {
        static string[] calisanlar = new string[] { "Melih", "Mehmet", "İlknur", "Tuğba", "Fatih" };
        static double[] maaslar = new double[5];
        static void Main(string[] args)
        {
            Selamliyorum();
            Selamliyorum("irem");
            Selamliyorum("irem","kars");

            bool DevamMi = true;
            while (DevamMi)
            {
                for (int i = 0; i < calisanlar.Length; i++)
                {
                    Console.WriteLine(i + ")" + calisanlar[i]);
                }

                Console.WriteLine("Maaş Hesaplanacak Çalışanın Numarasını Gir: ");
                int index = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Maaş - " + calisanlar[index] + ":");

                Console.WriteLine("Çalışma saati:");
                int calismaSaati = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Saatlik ücret");
                int saatlikÜcret = Convert.ToInt32(Console.ReadLine());

                if (calismaSaati <= 270)
                {
                    maaslar[index] = MaasHesapla(calismaSaati, saatlikÜcret);
                }
                else
                {
                    double mesai = Mesaihesapla(calismaSaati);
                    maaslar[index] = MaasHesapla(calismaSaati, saatlikÜcret, mesai);
                }
                Console.WriteLine("Yeni Maaş Hesabı Yapacak mısın:E/H");
                string deger = Console.ReadLine().ToLower();
                if (deger != "e")
                    DevamMi = false;
            }
            Console.WriteLine("\n*******************\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Personel adı: {calisanlar[i]} Maaş: {maaslar[i]} ");
            }
        }

        #region Metot Overload
        //Metot Overload: Metot asiri yuklemesi durumu ayni isimde birden fazla metodun bulunmasi ama hepsinin parametrelerinin farkli olmasi ile olusur.

        static void Selamliyorum()
        {
            Console.WriteLine("Selamla");
        }
        static void Selamliyorum(string ad)
        {
            Console.WriteLine($"Selamla {ad}");
        }
        static void Selamliyorum(string ad, string soyad)
        {
            Console.WriteLine($"Selamla {ad} {soyad}");
        }
        #endregion

        #region Metot Overloading - Ornek
        /*
             5 Çalışan

            MaaşHesapla Metodu
           -Çalışma saati 0 ve küçük olamaz.

            Çalışma Saati 270 kadar
              ->Maaş=ÇalışmaSaati * SaatlikÜcret

           Çalışma Saati 270 geçiyorsa
              ->Maaş= (ÇalışmaSaati * SaatlikÜcret) + MesaiÜcreti

           MesaiHesapla
           -270den sonra ..(Çalışma saaati - 270)
              ->Mesai=(ÇalışmaSaati * MesaiÜcret)

            */

        private static double MaasHesapla(double calismaSaati, double saatlikÜcret)
        {
            if (calismaSaati > 0)
            {
                return calismaSaati * saatlikÜcret;
            }
            else
            {
                throw new Exception("Maaş 0 dan küçük olamaz.");
            }
        }

        private static double MaasHesapla(double calismaSaati, double saatlikÜcret, double toplamMesai)
        {
            if (calismaSaati > 0)
            {
                return (calismaSaati * saatlikÜcret) + toplamMesai;
            }
            else
            {
                throw new Exception("Maaş 0 dan küçük olamaz.");
            }
        }

        private static double Mesaihesapla(double calismaSaati, double mesaiÜcreti = 550)
        {
            double saat = calismaSaati - 270;
            return saat * mesaiÜcreti;
        }




        #endregion
    }
}
