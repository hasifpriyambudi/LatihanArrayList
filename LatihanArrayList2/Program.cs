using System;
using System.Collections;

namespace LatihanArrayList2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.NamaMahasiwa = "Erik";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.NamaMahasiwa = "Wely";

            Dosen dosen1 = new Dosen();
            dosen1.Nik = "0043";
            dosen1.NamaDosen = "Jhono";

            Dosen dosen2 = new Dosen();
            dosen2.Nik = "0045";
            dosen2.NamaDosen = "Jhoni";

            ArrayList list = new ArrayList();

            list.Add(mhs1);
            list.Add(mhs2);
            list.Add(dosen1);
            list.Add(dosen2);

            Console.WriteLine("ID    Nama    Status");
            Console.WriteLine("====================");
            
            // Akses Elemen arraylist
            foreach (Mahasiswa mhs in list){
                Console.WriteLine("{0}, {1}, Mahasiswa", mhs.Nim, mhs.NamaMahasiwa);
            }
            Console.ReadKey();
        }
    }

    public class Dosen
    {
        public string Nik { get; set; }
        public string NamaDosen { get; set; }
    }

    public class Mahasiswa
    {
        public string Nim { get; set; }
        public string NamaMahasiwa { get; set; }
    }
}
