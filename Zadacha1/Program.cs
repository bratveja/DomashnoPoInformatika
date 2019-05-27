
using System;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pal = Console.ReadLine();
            Console.WriteLine(Palindrom(pal));
        }

        private static bool Palindrom(string pal)
        {
            int start = 0;
            int end = pal.Length - 1;
            for (int i = 0; i < pal.Length / 2; i++)
            {
                if (pal[start] != pal[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}