using PerfectDataStructures;
using System;
using System.Collections.Generic;

namespace PerfectDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var ogrenciListesi = new List<Ogrenci>()
            {
                new Ogrenci(10, "Ali", "Biner" , true),
                new Ogrenci(20, "Fatma", "Dağ" , false),
                new Ogrenci(30, "Mehmet", "Avşar" , true),

            };
            ogrenciListesi.ForEach(o => Console.WriteLine(o));
            Console.ReadKey();
        }
    }
}
