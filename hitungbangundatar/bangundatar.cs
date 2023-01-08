using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hitungbangundatar
{
    public class bangundatar
    {
        public int lpersegi()
        {
            Console.WriteLine("Masukan panjang sisi: ");
            int sisi = int.Parse(Console.ReadLine());

            int jumlah = sisi * sisi;
            Console.WriteLine("Luas persegi adalah: " + jumlah);

            return jumlah;
        }

        public int kpersegi()
        {
            Console.WriteLine("Masukan panjang sisi: ");
            int sisi = int.Parse(Console.ReadLine());

            int jumlah = sisi * 4;
            Console.WriteLine("Keliling persegi adalah: " + jumlah);

            return jumlah;
        }

        public int lpersegipanjang()
        {
            Console.WriteLine("Masukan panjang persegi panjang: ");
            int panjangpp = int.Parse(Console.ReadLine());

            Console.WriteLine("Masukan lebar persegi panjang: ");
            int lebarpp = int.Parse(Console.ReadLine());

            int jumlah = panjangpp * lebarpp;
            Console.WriteLine("Luas persegi panjang adalah: " + jumlah);

            return jumlah;
        }

        public int kpersegipanjang()
        {
            Console.WriteLine("Masukan panjang persegi panjang: ");
            int panjangpp = int.Parse(Console.ReadLine());

            Console.WriteLine("Masukan lebar persegi panjang: ");
            int lebarpp = int.Parse(Console.ReadLine());

            int jumlah = 2 * (panjangpp + lebarpp);
            Console.WriteLine("Keliling persegi panjang adalah: " + jumlah);

            return jumlah;
        }

        public int lsegitiga()
        {
            Console.WriteLine("Masukan alas segitiga: ");
            int alas = int.Parse(Console.ReadLine());

            Console.WriteLine("Masukan tinggi segitiga: ");
            int tinggi = int.Parse(Console.ReadLine());

            int jumlah = (alas * tinggi) / 2;
            Console.WriteLine("Luas segitiga adalah: " + jumlah);

            return jumlah;
        }

        public int ksegitiga()
        {
            Console.WriteLine("Masukan sisi miring segitiga: ");
            int sisim = int.Parse(Console.ReadLine());

            Console.WriteLine("Masukan alas segitiga: ");
            int alas = int.Parse(Console.ReadLine());

            int jumlah = 2 * sisim + alas;
            Console.WriteLine("Luas segitiga adalah: " + jumlah);

            return jumlah;
        }
    }
}
