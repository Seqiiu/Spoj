using System;

namespace PRIME_T
{
    class Program
    {
        private static bool CzyPierwsza(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int liczba = int.Parse(Console.ReadLine());
                if (CzyPierwsza(liczba))
                    Console.WriteLine("TAK");
                else
                    Console.WriteLine("NIE");
            }
        }
    }
}
