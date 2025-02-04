using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetodePertama();
            MetodeKedua();
            MetodeKetiga();
            MetodeKeempat();
            MetodeKelima();
        }
        public static void MetodePertama()
        {
            Console.WriteLine("ini adalah function 1");
            Console.WriteLine("ini adalah metode pertama");
        }
        static void MetodeKedua()
        {
            Console.WriteLine("ini adalah function 2");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"ini adalah angka {i}");
            }
        }
        static void MetodeKetiga() 
        {
            int i = 10;
            while (i < 20)
            {
                Console.WriteLine($"ini adalah angka{i}");
                i++;
            }
        }
        static void MetodeKeempat()
        {
            int j = 21;
            do
            {
                Console.WriteLine($"ini adalah angka {j}");
                j++;
            }
            while(j < 20);
        }
        static void MetodeKelima() 
        {
            int angka = 10;
            if(angka > 0 )
            {
                Console.WriteLine($"angka {angka} adalah positif");
            }
            else if(angka == 0)
            {
                Console.WriteLine($"angka {angka} adalah nol");
            }
            else
            {
                Console.WriteLine($"angka {angka} adalah negatif");
            }
        }
    }
}
