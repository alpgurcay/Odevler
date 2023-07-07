using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastgeleSayi
{
    internal class Program
    {
        static int[] dizi = new int[10];
        static void Main(string[] args)
        {
            sayi();
            dizieleman();

            int max = enbuyuk();
            Console.WriteLine("En Büyük Değer: " + max);

            int min = enkucuk();
            Console.WriteLine("En Küçük Değer: " + min);

        }
        static void sayi()
        {
            Console.WriteLine("Lütfen 10 tane sayı girin:");

            for (int i = 0; i < 10; i++)
            {
                bool gecerliSayi = false;
                int sayi;

                do
                {
                    Console.Write("Sayı " + (i + 1) + ": ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out sayi))
                    {
                        gecerliSayi = true;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz bir sayı girdiniz. Tekrar deneyin.");
                    }
                } while (!gecerliSayi);

                dizi[i] = sayi;
            }
        }

        static void dizieleman()
        {
            Console.WriteLine("Dizi elemanları:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Eleman " + (i + 1) + ": " + dizi[i]);
            }
        }

        static int enbuyuk()
        {
            int max = dizi[0];

            for (int i = 1; i < 10; i++)
            {
                if (dizi[i] > max)
                {
                    max = dizi[i];
                }
            }

            return max;
        }

        static int enkucuk()
        {
            int min = dizi[0];

            for (int i = 1; i < 10; i++)
            {
                if (dizi[i] < min)
                {
                    min = dizi[i];
                }
            }
          return min;
        }

    }
}
