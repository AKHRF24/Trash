using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array();
            List();
        }

        //Array

        static void Array()
        {
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Elemen pertama: " + numbers[0]);

            Console.WriteLine("Semua elemen array: ");
            for (int i = 2; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        //List

        static void List()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            numbers.Add(6);
            //numbers.Insert(4, 10);
            numbers.Remove(6);
            //numbers.RemoveAt(2);

            Console.WriteLine("Elemen pertama: " + numbers[0]);

            Console.WriteLine("Semua elemen list: ");
            for (int i = 0; i < 3; i++)
            {

                numbers.Remove(i);
            }
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Pasien
    {
        public string Nama { get; set; }
        public int Umur { get; set; }

        public Pasien(String nama, int umur)
        {
            Nama = nama;
            Umur = umur;
        }

        public override string ToString()
        {
            return $"Nama: {Nama}, Umur: {Umur}";
        }
    }

    static void main()
    {
        List<Pasien> daftarPasien = new List<Pasien>;
    }
}
