using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsiproject2370
{
    class Program
    {


        static void Main(string[] args)
        {
            Karyawan kry1 = new Karyawan();

            kry1.Nik = "18998811";
            kry1.Nama = "yudha pratama";
            kry1.GajiBulanan = 4000000;

            Karyawan kry2 = new Karyawan();
            kry2.Nik = "342656742";
            kry2.Nama = "kurniady";
            kry2.GajiBulanan = 3000000;

            Console.WriteLine("No\tNik/Nama\t\tGaji Bulanan");
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("1.\t{0}  {1}\t\t{2}\n", kry1.Nik, kry1.Nama, kry1.GajiBulanan);
            Console.WriteLine("2.\t{0}  {1}\t\t{2}\n", kry2.Nik, kry2.Nama, kry2.GajiBulanan);
            
            Console.WriteLine("\n\n");
            Console.WriteLine("Asyiikk Kenaikan Gaji 10%\n");
            Console.WriteLine("No\tNik/Nama\t\tGaji Bulanan");
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("1.\t{0}  {1}\t\t{2}\n", kry1.Nik, kry1.Nama, kry1.GajiBulanan + (kry1.GajiBulanan * 0.10));
            Console.WriteLine("2.\t{0}  {1}\t\t{2}\n", kry2.Nik, kry2.Nama, kry2.GajiBulanan + (kry2.GajiBulanan * 0.10));
            Console.ReadKey();
        }
    }
}
