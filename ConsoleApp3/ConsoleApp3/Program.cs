using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hasil = TambahDuaAngka(10, 12);
            Console.WriteLine("Hasil penjumlahan: " + hasil);
            int hasil1 = ParameterOptional();
            Console.WriteLine("Hasil perkalian " + hasil);
            perulangan(10);
            Console.ReadLine();
        }

        static int TambahDuaAngka(int a, int b)
        {
            int hasil = a + b;
            return hasil;
        }
        static int ParameterOptional(int a = 2, int b = 2)
        {
            int hasil = a * b;
            return hasil;
        }
        static void perulangan(int angka)
        {
            for (int i = 0; i <= angka; i++)
            {
                Console.WriteLine($"perulangan ke {i}");
            }
        }
    }
}
