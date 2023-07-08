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
            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");

                }
                Console.WriteLine();
            }

        }

    }
}
