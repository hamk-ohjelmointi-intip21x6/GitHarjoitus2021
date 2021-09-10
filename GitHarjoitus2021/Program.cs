using System;

namespace GitHarjoitus2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Terve Laskint!");


            Laskin laskimeni = new Laskin();
            Console.WriteLine("Laske lukujen 5 ja 16 erotus");
            int erotus = laskimeni.Erotus(5, 16);
            Console.WriteLine("erotus on: " + erotus);
        }
    }
}
