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


            Console.WriteLine("Laske lukujen 3005 ja 453 summa");
            int summa = laskimeni.Summa(3005, 453);
            Console.WriteLine("summa on: " + summa);

            Console.WriteLine("Laske lukujen 15 ja 4 jakojäännös");
            int jakojaannos = laskimeni.JakoJaannos(15, 4);
            Console.WriteLine("Jakojäännös on: " + jakojaannos);
        }
    }
}
