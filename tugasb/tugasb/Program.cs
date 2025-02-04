using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int jumlahPasien;
        do
        {
            Console.Write("Masukkan jumlah pasien (minimal 3): ");
        } while (!int.TryParse(Console.ReadLine(), out jumlahPasien) || jumlahPasien < 3);

        var namaPasien = new List<string>();
        var usiaPasien = new List<int>();
        var suhuTubuhPasien = new List<double>();

        for (int i = 0; i < jumlahPasien; i++)
        {
            Console.WriteLine($"\nData Pasien ke-{i + 1}");
            Console.Write("Nama: ");
            namaPasien.Add(Console.ReadLine() ?? "Tidak diketahui");

            Console.Write("Usia: ");
            usiaPasien.Add(int.TryParse(Console.ReadLine(), out int usia) ? usia : 0);

            Console.Write("Suhu tubuh (°C): ");
            suhuTubuhPasien.Add(double.TryParse(Console.ReadLine(), out double suhu) ? suhu : 36.5);
        }

        Console.WriteLine("\nHasil Diagnosa Kesehatan:");
        for (int i = 0; i < jumlahPasien; i++)
        {
            string kondisiKesehatan = suhuTubuhPasien[i] < 36.5 ? "Suhu tubuh rendah." : suhuTubuhPasien[i] <= 37.5 ? "Suhu tubuh normal." : "Demam.";
            Console.WriteLine($"\nPasien: {namaPasien[i]}\nUsia: {usiaPasien[i]}\nSuhu Tubuh: {suhuTubuhPasien[i]}°C\nKondisi Kesehatan: {kondisiKesehatan}");
        }
    }
}
