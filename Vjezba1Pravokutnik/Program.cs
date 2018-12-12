using System;

namespace Vjezba1Pravokutnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Izraditi razred pravokutnik koji: (https://hr.wikipedia.org/wiki/Pravokutnik)
            // 
            // > može izračunati svoju površinu
            // > ima konstruktor
            // > nije ga moguće stvoriti bez zadavanja dimenzija
            // > ima metode za postavljanje/dohvat vrijednosti


            // Pravokutnik p1 = new Pravokutnik();

            Pravokutnik p2 = new Pravokutnik(3, 4);

            Console.WriteLine("Površina : {0}", p2.izracunajPovrsinu());

        }
    }
}
