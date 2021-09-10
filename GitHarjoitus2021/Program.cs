using System;

namespace GitHarjoitus2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laskimen ensimmäinen versio. 1.0V");

            Laskin laskimeni = new Laskin();
            
            Console.WriteLine("Laske lukujen 148 ja 56 erotus");
            int erotus = laskimeni.Erotus(148, 56);
            Console.WriteLine("erotus on: " + erotus);

            Console.WriteLine("Laske lukujen 3005 ja 453 summa");
            int summa = laskimeni.Summa(3005, 453);
            Console.WriteLine("summa on: " + summa);

            Console.WriteLine("Laske lukujen 74 ja 222 tulo");
            int tulo = laskimeni.Tulo(74, 222);
            Console.WriteLine("summa on: " + tulo);

            Console.WriteLine("Laske lukujen 48 ja 87 jaon tulos");
            int tulos = laskimeni.JakoLasku(48, 87);
            Console.WriteLine("Jakojäännös on: " + tulos);

            Console.WriteLine("Laske lukujen 15 ja 4 jakojäännös");
            int jakojaannos = laskimeni.JakoJaannos(15, 4);
            Console.WriteLine("Jakojäännös on: " + jakojaannos);
        }
    }
}
