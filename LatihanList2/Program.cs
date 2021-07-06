using System;
using System.Collections.Generic;

namespace LatihanList2{
    class Program{
        static void Main(string[] args){
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "12345";
            mhs1.NamaMahasiswa = "Hasif";

            Mahasiswa mhs2 =  new Mahasiswa();
            mhs2.Nim = "12346";
            mhs2.NamaMahasiswa = "Priyambudi";

            Dosen dosen1 = new Dosen();
            dosen1.Nik = "1234567890";
            dosen1.NamaDosen = "Jhono";

            // Membuat Objek List
            List<Mahasiswa> list = new List<Mahasiswa>();
            list.Add(mhs1);
            list.Add(mhs2);

            Console.WriteLine("NIM    NAMA");
            Console.WriteLine("===========");
            // Akses element list
            foreach (Mahasiswa maha in list){
                Console.WriteLine("{0}, {1}",maha.Nim,maha.NamaMahasiswa);  
            }
            Console.ReadKey();
        }
    }
    public class Dosen{
        public string Nik {get;set;}
        public string NamaDosen {get;set;}

    }

    public class Mahasiswa{
        public string Nim{get;set;}
        public string NamaMahasiswa{get;set;}
    }
}
