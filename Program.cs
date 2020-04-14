using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2722
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("NIK\t\tNama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------------------");
            Karyawan karyawan = new Karyawan("19701234", "Agus", 5000000);
            Karyawan karyawan2= new Karyawan("20040678", "Budi", 7500000);

            Console.WriteLine("\n");
            Console.WriteLine("Asyiiiik!!! Kenaikan Gaji 10%");
            Console.WriteLine("\n");
            Console.WriteLine("NIK\t\tNama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------------------");

            karyawan.NaikGaji();
            karyawan2.NaikGaji();


            Console.ReadKey();

        }
    }
}
