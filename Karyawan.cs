using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4286
{
    public class Karyawan
    {
        //constructor
        public void Karyawan(string nik, string nama, int gajibulanan)
        // properties
        public string Nama{ get; set; }
        public string Nik { get; set; }
        public int GajiBulanan { get; set; }

        //method
        public void NikNama()
        {
            Console.WriteLine("{0}{1}{2}", Nama, Nik, GajiBulanan);
        }

        public void NaikGaji()
        {
            Console.WriteLine("Selamat Gaji Anda naik 10%");
            int kenaikan;

            kenaikan = GajiBulanan * 110;
            GajiBulanan = kenaikan / 100;

        }
        public void SetNaikGaji()
        {
            Console.WriteLine("Nama/NIK          Gaji Bulanan");
            Console.WriteLine("Nama / NIK           Gaji Bulanan");
        }
    }
}
