using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba1Pravokutnik
{
    // Izraditi razred pravokutnik koji: (https://hr.wikipedia.org/wiki/Pravokutnik)
    // 
    // > može izračunati svoju površinu
    // > ima konstruktor
    // > nije ga moguće stvoriti bez zadavanja dimenzija
    // > ima metode za postavljanje/dohvat vrijednosti

    class Pravokutnik
    {
        private double a;
        private double b;

        /*
        public Pravokutnik()
        {

        }
        */

        public Pravokutnik(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double dohvatiA()
        {
            return a;
        }

        public void postaviA(double a)
        {
            this.a = a;
        }

        public double izracunajPovrsinu()
        {
            return a * b;
        }

    }
}
