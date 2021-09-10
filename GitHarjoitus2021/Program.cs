using System;

namespace GitHarjoitus2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Terve Laskin!");


            Laskin laskimeni = new Laskin();
            
            Console.WriteLine("Laske lukujen 148 ja 56 erotus");
            int erotus = laskimeni.Erotus(148, 56);
            Console.WriteLine("erotus on: " + erotus);


            Console.WriteLine("Laske lukujen 1002 ja 256 summa");
            int summa = laskimeni.Summa(1002, 256);
            Console.WriteLine("summa on: " + summa);
        }
    }
}
