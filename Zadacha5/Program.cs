using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha5
{
    class Program
    {
        static void Pointer()
        {
            List<string> points = new List<string>();
            Console.Write("Points count:");
            int d = int.Parse(Console.ReadLine());
            if (d <= 3)
            {
                Console.WriteLine("There is no D under " + d + " points");
                return;
            }

            Console.WriteLine("Enter two numbers [x] [y]");
            Console.Write("Enter coords [x, y]:");
            for (int i = 0; i < d; i++)
            {
                points.Add(Console.ReadLine());
            }

            double dim = 0;
            for (int i = 1; i < points.Count - 1; i++)
            {
                for (int j = 0; j < points.Count; j++)
                {
                    if (i == j || i == j - 1 || i == j + 1)
                    {
                        continue;
                    }
                    else
                    {
                        int[] xy = points[i].Split().Select(int.Parse).ToArray();
                        int[] xy0 = points[j].Split().Select(int.Parse).ToArray();
                        int x = xy0[0] - xy[0];
                        int y = xy0[1] - xy[1];
                        double lengthOfPoints = Math.Sqrt(x * x + y * y);
                        if (lengthOfPoints > dim)
                        {
                            dim = lengthOfPoints;
                        }
                    }
                }
            }
            Console.WriteLine($"Max D: {dim}");
        }

        static void Main(string[] args)
        {
            Pointer();
        }
    }
}