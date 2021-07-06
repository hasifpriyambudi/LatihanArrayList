using System;
using System.Collections;
namespace LatihanArrayList{
    class Program{
        static void Main(string[] args){
            ArrayList arrBilangan = new ArrayList();

            arrBilangan.Add(12);
            arrBilangan.Add(14);
            arrBilangan.Add(17);

            int bil = (int)arrBilangan[2];
            Console.WriteLine(bil);
            Console.WriteLine();

            foreach (int bilangan in arrBilangan){
                Console.WriteLine(bilangan);
            }
            Console.ReadKey();
        }
    }
}
