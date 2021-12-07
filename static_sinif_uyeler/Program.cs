using System;

namespace static_sinif_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(calisan.Calisansayisi);
            calisan calisan1=new calisan ("Volkan","Şallı","KGT");
            Console.WriteLine(calisan.Calisansayisi);
            calisan calisan2=new calisan("Polat","Alemdar","KGT");
            calisan calisan3=new calisan("Ali","Candan","KGT");
            calisan calisan4;
            calisan4=new calisan("radi","abi","özcanshow");
            Console.WriteLine(calisan.Calisansayisi);

            

            Console.WriteLine("Toplama Sonucu 100 + 50 = "+islemler.topla(100,50));
            Console.WriteLine("Toplama Sonucu 400 - 50 = "+islemler.cikar(400,50));
             
        }
    }
    class calisan
    {
        private static int calisansayisi;

        public static int Calisansayisi { get => calisansayisi;}

        private string isim;
        private string soyisim;
        private string departman;
        public calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            calisansayisi++;


        }
        static calisan()
        {
            calisansayisi=0;
        }

    }
    static class islemler
    {
        public static long topla(int a, int b)
        {
            return a + b;
        }

        public static long cikar (int a, int b)
        {
            return a - b;
        }
    }
}