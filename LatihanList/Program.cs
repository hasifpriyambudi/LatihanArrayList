using System;
using System.Collections.Generic;

namespace LatihanList{
    class Program{
        static void Main(string[] args){
            // Membuat Objek List untuk menampung tipe data
            List<int> listNilai = new List<int>();

            // Menambahkan Element List
            // Tidak Ada Proses Boxing
            listNilai.Add(70);
            listNilai.Add(100);
            listNilai.Add(85);

            // Akses Element List
            // Tidak ada proses Unboxing
            int nilaiElement1 = listNilai[1];

            Console.WriteLine(nilaiElement1);
            Console.WriteLine();

            foreach (int nilai in listNilai){
                Console.WriteLine(nilai);
            }

            Console.ReadKey();
        }
    }
}
