using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text ;
            while ((text = Console.ReadLine()) != null)
            {
                string[] tab = text.Split(' ');
                int wynik =0;

                wynik = tab[0] == "+" ? int.Parse(tab[1]) + int.Parse(tab[2]) : wynik;
                wynik = tab[0] == "-" ? int.Parse(tab[1]) - int.Parse(tab[2]) : wynik;
                wynik = tab[0] == "/" ? int.Parse(tab[1]) / int.Parse(tab[2]) : wynik;
                wynik = tab[0] == "*" ? int.Parse(tab[1]) * int.Parse(tab[2]) : wynik;
                wynik = tab[0] == "%" ? int.Parse(tab[1]) % int.Parse(tab[2]) : wynik;
                if (wynik!=0) Console.WriteLine(wynik);
            }
        }
    }
}
