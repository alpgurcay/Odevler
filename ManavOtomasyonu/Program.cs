using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        SortedList<string, int> meyveler = new SortedList<string, int> //sortedlist anahtar ve değeri sıralı tutar dizi gibi indekslenebiliyor
        {
             {"ELMA",20 },
             {"ARMUT",20 },
             {"CILEK",20 }
        };
        SortedList<string, int> sebzeler = new SortedList<string, int>
        {
            {"DOMATES",20 },
            {"SALATALIK",20 },
            {"PATATES",20 }
        };
        SortedList<string, int> kullanicilar = new SortedList<string, int> { };
        SortedList<string, int> musteriler = new SortedList<string, int> { };
        bool run = true;
        while (run)
        {
            Console.WriteLine("HALE HOŞGELDİNİZ");
            Console.WriteLine("Meyve - (M) / Sebze - (S) / Liste - (L)");
            string secim = Console.ReadLine();
            if (secim.ToUpper() == "M")
            {
                foreach (KeyValuePair<string, int> item in meyveler)
                {
                    Console.WriteLine(item.Key + " " + item.Value);

                }
                Console.WriteLine("Almak İstediğiniz Ürünü Girin");
                string urun = Console.ReadLine().ToUpper();
                Console.WriteLine("Adet Girin");
                int adet = int.Parse(Console.ReadLine());

                if (meyveler.ContainsKey(urun))
                {
                    int mevcutMiktar = meyveler[urun]; 
                    if (mevcutMiktar >= adet) 
                    {
                        if (kullanicilar.ContainsKey(urun))
                        {
                            kullanicilar[urun] += adet;
                        }
                        else
                        {
                            kullanicilar.Add(urun, adet);
                        }
                        meyveler[urun] = mevcutMiktar - adet;
                    }
                    else
                    {
                        Console.WriteLine("Stok Yok");
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı İşlem");
                }
            }

            else if (secim.ToUpper() == "S")
            {
                foreach (KeyValuePair<string, int> item in sebzeler)
                {
                    Console.WriteLine(item.Key + " " + item.Value);


                }
                Console.WriteLine("Almak İstediğiniz Ürünü Girin");
                string urun2 = Console.ReadLine().ToUpper();
                Console.WriteLine("Adet Girin");
                int adet2 = int.Parse(Console.ReadLine());

                if (sebzeler.ContainsKey(urun2))
                {
                    int mevcut = sebzeler[urun2];
                    if (adet2 <= mevcut)
                    {
                        if (kullanicilar.ContainsKey(urun2))
                        {
                            kullanicilar[urun2] += adet2;
                        }
                        else
                            kullanicilar.Add(urun2, adet2);
                        sebzeler[urun2] = mevcut - adet2;
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz Stok");
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı İşlem");

                }
            }
            else if (secim.ToUpper() == "L")
            {
                Console.WriteLine("Listeniz ");
                foreach (KeyValuePair<string, int> item in kullanicilar)
                {
                    Console.WriteLine(item.Key + "  " + item.Value);
                }
                Console.WriteLine("Başka bir arzunu var mı? (E-H)");
                string cevap = Console.ReadLine();
                if (cevap.ToUpper() == "E")
                {
                    

                }
                else if (cevap.ToUpper() == "H")
                {
                    Thread.Sleep(2500);
                    Environment.Exit(0);
                }
            }
        }
        Console.Clear();
        Console.WriteLine("MANAVA HOŞGELDİNİZ");
        Console.WriteLine("Ürünler");

        bool run1 = true;

        while (run1)
        {
            foreach (KeyValuePair<string, int> item in kullanicilar)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine();

            Console.WriteLine("Almak İstediğiniz Ürünleri Girin");
            string urunler = Console.ReadLine().ToUpper();
            Console.WriteLine("Adet Girin");
            int adets = int.Parse(Console.ReadLine());

            Console.Clear();

            if (kullanicilar.ContainsKey(urunler))
            {
                int mevcut = kullanicilar[urunler];
                if (adets <= mevcut)
                {
                    if (musteriler.ContainsKey(urunler))
                    {
                        musteriler[urunler] += adets;

                    }
                    else
                        musteriler.Add(urunler, adets);
                    kullanicilar[urunler] = mevcut - adets;
                }
                else if (adets >= mevcut)
                {
                    Console.WriteLine("Miktar Fazla");

                }
            }
            else
            {
                Console.WriteLine("Hatalı İşlem");
            }
            Console.WriteLine("Başka bir Arzunuz var mı? E/H");
            string cevap = Console.ReadLine().ToUpper();

            if (cevap.ToUpper() == "E")
            {

            }
            else if (cevap.ToUpper() == "H")
            {
                break;
            }
        }
        Console.Clear();
        Console.WriteLine("Almış Olduğunuz Ürünler");

        foreach (KeyValuePair<string, int> item in musteriler)
        {
            Console.WriteLine(item.Key + "  " + item.Value);
        }
        Console.ReadLine();
    }
}
