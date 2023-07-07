using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odevler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarpimTablosu(1, 10);
        }

        static void CarpimTablosu(int a, int b)
        {
            if (a < 1 || b > 10)
            {
                Console.WriteLine("Tablo 1 ile 10 Arasında Olmalıdır.");
                return;
            }

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    Console.Write($"{i} x {j} = {i * j}\t");

                }
                Console.WriteLine();
            }

        }

    }
}
