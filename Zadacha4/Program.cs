using System;

namespace Zadacha4
{
    class Program
    {
        private static bool Const(int[] arr, int x)
        {
            int a;
            for (int i = 0; i < arr.Length; i++)
            {
                a = arr[i];
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    if (arr[i] + arr[j] == x)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static void Elements()
        {
            Console.Write("Elements counts: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum: ");
            int x = Convert.ToInt32(Console.ReadLine()); ;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i}: ");
                int c = Convert.ToInt32(Console.ReadLine());
                arr[i] = c;
            }
            if (Const(arr, x))
            {
                Console.WriteLine($"Sum {x}");
            }
            else
            {
                Console.WriteLine($"Sum not found {x}");
            }
        }

        static void Main(string[] args)
        {

        }
    }
}