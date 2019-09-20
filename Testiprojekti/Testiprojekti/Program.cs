using System;

namespace Testiprojekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Laskin");

            var laskin = new Laskin();

            Console.WriteLine("Tulosta lukujen 5 ja 4 summa.");
            var summa = laskin.Summa(5, 4);
            Console.WriteLine(summa);

            Console.WriteLine("Tulosta lukujen 5 ja 4 erotus.");
            var erotus = laskin.Erotus(5, 4);
            Console.WriteLine(erotus);
        }
    }
}
