using System;

namespace Stos
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] tablica= new int[10];
            int aktualaWartosStosu = 0;
            bool pentla = true;
            char k;
            do
            {
                pentla =char.TryParse(Console.ReadLine(), out k);
                if (k==43)
                {
                    int wartosc = int.Parse(Console.ReadLine());
                    if (aktualaWartosStosu<=9)
                    {
                        tablica[aktualaWartosStosu] = wartosc;
                        Console.WriteLine(":)");
                        aktualaWartosStosu++;
                    }
                    else
                    {
                        Console.WriteLine(":(");
                    }
                    
                }
                if (k==45)
                {
                    if (aktualaWartosStosu>0)
                    {
                        Console.WriteLine(tablica[aktualaWartosStosu-1]);
                        aktualaWartosStosu--;
                    }
                    else
                    {
                        Console.WriteLine(":(");
                    }
                    
                }

            } while (pentla);


        }
    }
}
