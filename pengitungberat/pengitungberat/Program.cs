using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Selamat datang di Program Penghitung BMI!");

        bool lanjut = true;
        while (lanjut)
        {
            Console.Write("Masukkan berat badan (kg): ");
            double berat = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan tinggi badan (m): ");
            double tinggi = Convert.ToDouble(Console.ReadLine());

            double bmi = CalculateBMI(berat, tinggi);

            Console.WriteLine($"Nilai BMI Anda: {bmi:F2}");
            if (bmi < 18.5)
            {
                Console.WriteLine("Kategori: Berat badan kurang");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("Kategori: Berat badan normal");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("Kategori: Berat badan berlebih");
            }
            else
            {
                Console.WriteLine("Kategori: Obesitas");
            }



            Console.Write("Apakah Anda ingin menghitung BMI untuk orang lain? (y/n): ");
            string jawaban = Console.ReadLine().ToLower();
            if (jawaban != "y")
            {
                lanjut = false;
            }
        }

        Console.WriteLine("Terima kasih telah menggunakan Program Penghitung BMI. Sampai jumpa!");
    }

    static double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }
}