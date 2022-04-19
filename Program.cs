// See https://aka.ms/new-console-template for more information
using System;

namespace ResponsiPemrograman4286
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kry1 = new Karyawan();
            Karyawan kry2 = new Karyawan();


            kry1.Nama = "Dion";
            kry1.Nik = "12345";
            kry1.GajiBulanan = 5000000;

            kry2.Nama = "Adit";
            kry2.Nik = "54321";
            kry2.GajiBulanan = 3000000;


            Console.WriteLine("No. Nama/NIK Gaji Bulanan");

            Console.WriteLine("***************************");
            Console.WriteLine("1"); kry1.NikNama();
            Console.WriteLine("2"); kry2.NikNama();
            Console.WriteLine();

            kry1.NaikGaji();
            kry2.NaikGaji();

            Console.WriteLine("No. Nama/NIK Gaji Bulanan");
            Console.WriteLine("***************************");
            Console.WriteLine("1"); kry1.NikNama();
            Console.WriteLine("2"); kry2.NikNama();
            Console.WriteLine();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}