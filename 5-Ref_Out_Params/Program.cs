namespace _5_Ref_Out_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ref-Kullanimi
            //Ref, metotlara veya metotlardan değer tiplerin referanslarını iletmek veya döndürmek için kullanılır.
            //Diğer bir deyişle, referans yoluyla iletilen bir değerde yapılan herhangi bir değişikliğin yalnızca taşıdığı değeri değil, adresteki (referans) değerininide değiştirdiğiniz için bu değişikliği yansıtıcağı anlamına gelir.

            //Değişken a ve b
            int a = 10, b = 12;

            Console.WriteLine("İşlem öncesi a değişkeni: {0}", a);
            Console.WriteLine("İşlem öncesi b değişkeni: {0}", b);

            toplamDeger(a);

            //A değişkeni işlem sonrası
            Console.WriteLine("İşlem sonrası a değişkeni: {0}", a);

            farkDeger(ref b);

            //B değişkeni işlem sonrası
            Console.WriteLine("İşlem sonrası b değişkeni: {0}", b);

            //Değer parametreli metot
            int toplamDeger(int a)
            {
                return a += 10;
            }

            //Ref parametreli metot
            void farkDeger(ref int b)
            {
                b -= 5;
            }


            #endregion

            #region OutKullanimi

            //Out, out ile bir kullanıcı metotdan bir dan fazla değer döndürebilir.

            int i, j;

            Toplam(out i, out j);

            Console.WriteLine("Toplama Değer i: " + i);
            Console.WriteLine("Toplama Değer j: " + j);

            int fark = Fark(out i, out j);

            Console.WriteLine("Fark Değer i: " + i);
            Console.WriteLine("Fark Değer j: " + j);
            Console.WriteLine("Fark Değer Sonuc: " + fark);

            double bolum;

            int carpim = Carpim(5, 9, out bolum);
            Console.WriteLine("Carpim Değer: " + carpim);
            Console.WriteLine("Bölüm Değer: " + bolum);

            void Toplam(out int p, out int q)
            {
                p = 30;
                q = 40;
                p += p;
                q += q;
            }

            int Fark(out int p, out int q)
            {
                q = 30;
                p = 50;

                return q - p;
            }

            int Carpim(int sayi1, int sayi2, out double bolumu)
            {
                bolumu = Convert.ToDouble(sayi1) / Convert.ToDouble(sayi2);

                return sayi1 * sayi2;
            }
            #endregion

            #region Params
            //Params: Sinirsiz olarak parametre almayi saglayan anahtar kelimedir. Parametre belirtirken params ile belirtilen parametre sona yazilmalidir.
            static int FazlasiylaTopla(params int[] sayilar)
            {
                int toplam = 0;
                foreach (var item in sayilar)
                {
                    toplam += item;
                }
                return toplam;
            }

            static int Miktar(params string[] ifadeler)
            {
                int toplam = 0;
                foreach (var ifade in ifadeler)
                {
                    toplam += ifade.Length;
                }
                return toplam;
            }


            Console.WriteLine(Toplama(4, 5, 25, 19));

            int Toplama(params int[] sayilar)
            {
                int toplam = 0;

                for (int sayi = 0; sayi < sayilar.Length; sayi++)
                {
                    toplam += sayilar[sayi];
                }

                return toplam;
            }

            #endregion

        }
    }

}
