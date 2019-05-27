using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha2
{
    class Program
    {
        static void Filtur()
        {
            string textZaFiltrirane = Console.ReadLine();
            StringBuilder filtriran = new StringBuilder();

            for (int i = 0; i < textZaFiltrirane.Length; i++)
            {
                if (textZaFiltrirane[i] == ')' || textZaFiltrirane[i] == '(')
                    filtriran.Append(textZaFiltrirane[i]);
            }

            textZaFiltrirane = filtriran.ToString();
            List<char> skobi = new List<char>();
            bool balansiran = true;

            if (textZaFiltrirane[0] == ')')
            {
                balansiran = false;
            }
            else
            {
                for (int i = 0; i < textZaFiltrirane.Length; i++)
                {
                    if (textZaFiltrirane[i] == '(')
                        skobi.Add('(');
                    if (textZaFiltrirane[i] == ')')
                    {
                        if (skobi.Count > 0)
                        {
                            skobi.Remove('(');
                        }
                        else
                        {
                            balansiran = false;
                        }
                    }
                }
            }

            if (balansiran == false || skobi.Count != 0)
            {
                Console.WriteLine("Nebalansiran");
            }
            else
            {
                Console.WriteLine("Balansiran");
            }
        }

        static void Main(string[] args)
        {
            Filtur();
        }
    }
}