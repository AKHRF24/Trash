using System;
using System.Collections.Generic;

class Obat
{
    public string Nama { get; set; }
    public int Jumlah { get; set; }
    public decimal Harga { get; set; }

    public Obat(string nama, int jumlah, decimal harga)
    {
        Nama = nama;
        Jumlah = jumlah;
        Harga = harga;
    }

    public override string ToString()
    {
        return $"Nama Obat: {Nama}, Jumlah: {Jumlah}, Harga: {Harga:#,##0.00}";
    }
}

class InventarisApotek
{
    private List<Obat> daftarObat = new List<Obat>();

    public void TambahObat(Obat obat)
    {
        daftarObat.Add(obat);
        Console.WriteLine($"Obat {obat.Nama} berhasil ditambahkan ke dalam inventaris.");
    }

    public void TampilkanSemuaObat()
    {
        Console.WriteLine("\nSemua Obat dalam Inventaris:");
        Console.WriteLine("Daftar Obat dalam Inventaris:");
        foreach (var obat in daftarObat)
        {
            Console.WriteLine(obat);
        }
    }

    public void CariObat(string namaObat)
    {
        Console.WriteLine($"\nCari Obat:\nMasukkan nama obat yang dicari: {namaObat}");
        Console.WriteLine($"\nHasil Pencarian untuk '{namaObat}':");
        var obatDitemukan = daftarObat.Find(obat => obat.Nama.Equals(namaObat, StringComparison.OrdinalIgnoreCase));
        if (obatDitemukan != null)
        {
            Console.WriteLine(obatDitemukan);
        }
        else
        {
            Console.WriteLine("Obat tidak ditemukan dalam inventaris.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        InventarisApotek inventaris = new InventarisApotek();

        Console.WriteLine("Masukkan data obat ke dalam inventaris.");
        string input;
        do
        {
            Console.Write("Masukkan nama obat: ");
            string nama = Console.ReadLine();

            Console.Write("Masukkan jumlah obat: ");
            int jumlah = int.Parse(Console.ReadLine());

            Console.Write("Masukkan harga obat: ");
            decimal harga = decimal.Parse(Console.ReadLine());

            Obat obatBaru = new Obat(nama, jumlah, harga);
            inventaris.TambahObat(obatBaru);

            Console.Write("Apakah Anda ingin menambahkan obat lain? (y/n): ");
            input = Console.ReadLine();
        } while (input.Equals("y", StringComparison.OrdinalIgnoreCase));

        inventaris.TampilkanSemuaObat();

        Console.WriteLine("\nCari Obat:");
        do
        {
            Console.Write("Masukkan nama obat yang dicari: ");
            string namaObatDicari = Console.ReadLine();
            inventaris.CariObat(namaObatDicari);

            Console.Write("Apakah Anda ingin mencari obat lain? (y/n): ");
            input = Console.ReadLine();
        } while (input.Equals("y", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Program selesai.");
    }
}
