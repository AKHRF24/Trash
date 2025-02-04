using System;

namespace ConsoleApp
{
    class ContohKelas
    {
        private void MetodePrivate()
        {
            Console.WriteLine("Ini adalah metode private.");
        }

        public static void MetodeStatic()
        {
            Console.WriteLine("Ini adalah metode static.");
        }

        public void PanggilMetode()
        {
            MetodePrivate();
            MetodeStatic();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ContohKelas.MetodeStatic();
            ContohKelas contoh = new ContohKelas();
            contoh.PanggilMetode();
        }
    }
}