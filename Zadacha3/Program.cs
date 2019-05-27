using System;

namespace Zadacha3
{
    struct Colors
    {
        public static string red = "red\n";
        public static string blue = "blue\n";
        public static string white = "white\n";

    }
    class Program
    {
        public static void Swapper(string[] input, int i, int j)
        {
            string temp = input[i];
            input[i] = input[j];
            input[j] = temp;
        }

        public static void ColorPallet(string[] input)
        {
            Console.Write("Color: a length= ");
            int colorAlength = int.Parse(Console.ReadLine());
            Console.Write("Coolor: b length= ");
            int colorBLength = int.Parse(Console.ReadLine());

            int calc = input.Length - 1;
            while (colorAlength <= calc)
            {
                if (String.Equals(input[colorAlength], Colors.red))
                {
                    Swapper(input, colorAlength, colorBLength);
                    colorAlength++;
                    colorBLength++;
                }
                else if (String.Equals(input[colorAlength], Colors.blue))
                {
                    colorAlength++;
                }
                else if (String.Equals(input[colorAlength], Colors.white))
                {
                    Swapper(input, colorAlength, calc);
                    calc--;
                }
                else
                {
                    break;
                }
            }
        }

        public static void Main(string[] args)
        {
            string[] input =
                {
                Colors.white,
                Colors.white,
                Colors.white,
                Colors.white,
                Colors.white,
                Colors.white,
                Colors.white,
                Colors.red,
                Colors.white,
                Colors.blue,
                Colors.white,
                Colors.white,
                Colors.white
            };

            ColorPallet(input);
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}