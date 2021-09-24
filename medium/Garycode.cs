using System;

namespace Gray_code
{
    class Program
    {
        static void Main(string[] args)
        {
            int attempt = int.Parse(Console.ReadLine());
            for (int i = 0; i < attempt; i++)
            {
                int value = int.Parse(Console.ReadLine());
                double helper = Math.Pow(2, value);
                if (value != 0)
                {
                    string[] tab = new string[(int)helper];

                    GrayCode(value, tab);
                    foreach (var item in tab)
                    {
                        Console.WriteLine(Reverse(item));
                    }
                }
                Console.WriteLine();
            }
        }
        static string[] GrayCode(int n, string[] tab)
        {
            if (n == 1)
            {
                tab[0] = "0";
                tab[1] = "1";
                return tab;
            }
            else
            {
                GrayCode(n - 1, tab);
                int t = (int)Math.Pow(2, n) / 2;
                for (int i = 0; i < t; i++)
                {
                    tab[t + i] = tab[t - 1 - i];
                }
                for (int i = 0; i < t * 2; i++)
                {
                    if (i < t)
                        tab[i] += "0";
                    else
                        tab[i] += "1";
                }
                return tab;
            }
        }
        static string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
