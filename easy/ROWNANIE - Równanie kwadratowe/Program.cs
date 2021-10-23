using System;

public class Test
{
    public static void Main()
    {
        string liczba = null;
        while ((liczba = Console.ReadLine()) != null)
        {
            liczba = liczba.Replace(".", ",");

            string[] tab = liczba.Split(' ');
            float a = float.Parse(tab[0]);
            float b = float.Parse(tab[1]);
            float c = float.Parse(tab[2]);
            double wynik = Math.Pow(b, 2) - 4 * a * c;
            if (wynik > 0)
            {
                Console.WriteLine("2");
            }
            else if (wynik == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }

        }
    }
}