using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2722
{
    class Karyawan
    {
        public string NIK;
        public string Nama;
        public int Gaji;

        public Karyawan(string NIK, string Nama, int Gaji)
        {
            this.NIK = NIK;
            this.Nama = Nama;
            this.Gaji= Gaji;

            if (Gaji < 0)
            {
               
                Console.WriteLine("{0}\t{1}\t\t0", NIK, Nama);
            }
            else
            {
               
                Console.WriteLine("{0}\t{1}\t\t{2}", NIK, Nama, Gaji);

               
            }
        }
        
        public void NaikGaji()
        {
            string NIK = this.NIK;
            string Nama= this.Nama;
            int Gaji = this.Gaji;
           
            int Bonus = Gaji / 10;
            int KenaikanGaji = Gaji + Bonus;
            if(Gaji < 0)
            {

            Console.WriteLine("{0}\t{1}\t\t0", NIK, Nama);
            }

            else
            {
            Console.WriteLine("{0}\t{1}\t\t{2}", NIK, Nama, KenaikanGaji);
            }
        }

    }
}
