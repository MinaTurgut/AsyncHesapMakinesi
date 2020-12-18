using System;
using System.Threading.Tasks;


namespace AsyncHesapMakinesi
{
    class Program
    {
        public static async Task Hesapla(int num1, int num2, char islem)
        {
            if(islem == '+')
            {
                await Toplam(num1, num2);
            }

            if (islem == '-')
            {
                await Cıkarma(num1, num2);
            }

            if (islem == '*')
            {
                await Carpma(num1, num2);
            }

            if (islem == '/')
            {
                await Bolme(num1, num2);
            }
        }
       

        static async Task<int> Toplam(int sayi1, int sayi2)
        {
            int sonuc = await Task.Run(() => sayi1 + sayi2);
            Console.WriteLine("İki sayının toplama sonucu: {0}", sonuc);
            return sonuc;
        }

        static async Task<int> Cıkarma(int sayi1, int sayi2)
        {
            int sonuc = await Task.Run(() => sayi1 - sayi2);
            Console.WriteLine("İki sayının çıkarma sonucu: {0}", sonuc);
            return sonuc;
        }

        static async Task<int> Carpma(int sayi1, int sayi2)
        {
            int sonuc = await Task.Run(() => sayi1 * sayi2);
            Console.WriteLine("İki sayının çarpma sonucu: {0}", sonuc);
            return sonuc;
        }

        static async Task<int> Bolme(int sayi1, int sayi2)
        {
            int sonuc = await Task.Run(() => sayi1 / sayi2);
            Console.WriteLine("İki sayının bölme sonucu: {0}", sonuc);
            return sonuc;
        }

        static void Main(string[] args)
        {
            int sayii1 = 0;
            int sayii2 = 0;
            char islem;


            while(true)
            {
                Console.WriteLine("Birinci sayıyı giriniz: ");
                sayii1 = int.Parse(Console.ReadLine());
                Console.WriteLine("İkinci sayıyı giriniz: ");
                sayii2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Operator tipini giriniz: ");
                islem = char.Parse(Console.ReadLine());
                Hesapla(sayii1, sayii2, islem);


            }

            Console.ReadKey();
        }
    }
}
