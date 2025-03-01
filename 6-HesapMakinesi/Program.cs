namespace _6_HesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool devamMi = true;
            while (true)
            {
                HesapMakinası();
                devamMi = SorDevamMi();
            }

        }

        private static bool SorDevamMi()
        {
            Console.WriteLine("Devam Etmek İstiyor musunuz? (E/N)");
            string islem = Console.ReadLine();
            if (islem.ToLower() == "e")
                return true;
            else
                return false;
        }

        private static void HesapMakinası()
        {
            double sayi1, sayi2;
            string islem;

            Bilgi();
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen Bir işlem seçiniz: ");
            islem = Console.ReadLine();

            Console.WriteLine("Lütfen sayı ikiyi giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            if (islem == "+")
            {
                Console.WriteLine("Sonuç: " + Topla(sayi1, sayi2));
            }
            else if (islem == "-")
            {
                Console.WriteLine("Sonuç: " + Fark(sayi1, sayi2));
            }
            else if (islem == "*")
            {
                Console.WriteLine("Sonuç: " + Carp(sayi1, sayi2));

            }
            else if (islem == "/")
            {
                Console.WriteLine("Sonuç: " + Bolme(sayi1, sayi2));
            }
            else
            {
                Console.WriteLine("Hatalı giriş.");
            }
        }

        static void Bilgi()
        {
            Console.WriteLine("Basit Bir Hesap Makinası");
            Console.WriteLine("İşlem [Topla(+) Fark(-) Çarp(*) Böl(/)]");
        }

        static double Topla(double x, double y)
        {

            return x + y;
        }
        static double Fark(double x, double y)
        {

            return x - y;
        }
        static double Carp(double x, double y)
        {

            return x * y;
        }
        static double Bolme(double x, double y)
        {

            return x / y;
        }



    }
}
