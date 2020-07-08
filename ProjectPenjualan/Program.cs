using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Tambah Data Penjualan");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Tampilkan Penjualan");
            Console.WriteLine("4. Keluar");
            Console.WriteLine();
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Console.WriteLine("Tambah Data Penjualan");
            Console.WriteLine();
            Console.Write("Nota       : ");
            int nota = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tanggal    : ");
            string tanggal = Console.ReadLine();
            Console.Write("Customer   : ");
            string costumer = Console.ReadLine();
            Console.Write("Jenis [T/K]: ");
            char jenis = Convert.ToChar(Console.ReadLine());
            Console.Write("Total Nota : ");
            double total = Convert.ToDouble(Console.ReadLine());

            daftarPenjualan.Add(new Penjualan() {Nota = nota, Tanggal = tanggal, Costumer = costumer, Jenis = jenis, Total = total});

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
            Console.WriteLine("Hapus Data Penjualan");
            Console.WriteLine();
            Console.Write("Nota: ");
            int hapus = Convert.ToInt32(Console.ReadLine());
            for (int n = 0; n <daftarPenjualan.Count; n++)
            {
                Penjualan penjualan = daftarPenjualan[n];
                if (penjualan.Nota == hapus)
                {
                    daftarPenjualan.RemoveAt(n);
                    Console.WriteLine();
                    Console.WriteLine("Data Penjualan berhasil dihapus");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Data tidak ditemukan!");
                }
            }

            Console.WriteLine();
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            Console.WriteLine("Data Penjualan");
            Console.WriteLine();
            int no = 1;

            foreach (Penjualan penjualan in daftarPenjualan)
            {
                if (penjualan.Jenis == 'T' || penjualan.Jenis == 't')
                {
                    Console.WriteLine("{0}. {1}, {2}, {3}, Tunai, {4:N0}", no, penjualan.Nota, penjualan.Tanggal, penjualan.Costumer, penjualan.Total);
                }
                else if (penjualan.Jenis == 'K' || penjualan.Jenis == 'k')
                {
                    Console.WriteLine("{0}. {1}, {2}, {3}, Kredit, {4:N0}", no, penjualan.Nota, penjualan.Tanggal, penjualan.Costumer, penjualan.Total);
                }
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
