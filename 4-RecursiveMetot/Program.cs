namespace _4_RecursiveMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Toplama(4));

            int sayi = 5;
            int sonuc = Faktoriyel(sayi);
            Console.WriteLine($"{sayi} sayısının faktöriyeli: {sonuc}");
        }

        #region Recursive
        //Metodun kendi icerisinde kendisini cagirarak kullanma seklidir.

        //0 dan gonderilen sayiya kadar Toplama islemi yapan ve sonucu donduren metot
        static int Toplama(int sayi)
        {
            if (sayi == 1) return 1;
            else return sayi + Toplama(sayi - 1);
        }

        static int Faktoriyel(int n)
        {
            //Temel durmum: 0 faktoriyeli 1 dir.
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Faktoriyel(n - 1);
            }
        }
        #endregion
    }
}
