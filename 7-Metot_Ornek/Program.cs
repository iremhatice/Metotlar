namespace _7_Metot_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Bir tam sayı alan ve tam sayı basamaklarını çözümleyen programı yazınız.

              Girilen ifadenin doğru bir tam sayı olup olmadığını kontrol edilmeli.Eğer ki
              kullanıcının giriş yaptığı değer tam sayı değilse kullanıcıdan doğru formatta bir sayı istenmelidir.

              Ayrıca yapılacak işlemler kesinlikle tam sayı tipinde değişkenler kullanarak
              yapılmalıdır.Bu  uygulamada string metot kullanılmayacak.Kullanıcı programı sonlandırmak için sayı giriş aşamasında exit yazarsa programı sonlandırabilecek.
                  */

            int sayi = TamSayıAl();
            SayiCozumlemeyiYazdır(sayi);
            Console.ReadLine();
        }

        private static void SayiCozumlemeyiYazdır(int sayi)
        {
            int sayac = 0;
            while (sayi > 0)
            {
                Console.WriteLine((sayi % 10) + "X" + Math.Pow(10, sayac) + "=" + (sayi % 10) * Math.Pow(10, sayac));
                sayi = sayi / 10;
                sayac++;
            }
        }

        private static int TamSayıAl()
        {
            Console.WriteLine("Bir tam sayı giriniz:");
            try
            {
                string cevap = Console.ReadLine();
                if (cevap.ToLower() == "exit")
                    Environment.Exit(0);
                int sayi = Convert.ToInt32(cevap);
                return sayi;
            }
            catch (Exception)
            {
                YanlişVeriHatasi();
                return TamSayıAl();
            }
        }

        private static void YanlişVeriHatasi()
        {
            Console.WriteLine("Girilen veri belirtilen formatta değildit.Lütfen tam sayı girişi yapınız.");
        }

    }
}
