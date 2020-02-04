using System;
using System.Collections.Generic;

namespace TechDevGuide
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string texto = Console.ReadLine();

            Decom(texto);

            Console.WriteLine(texto);

            Console.ReadLine();
        }

        private static string Decom(string texto)
        {
            List<char> times = new List<char>();
            List<char> textoRepetir = new List<char>();
            int numero = 0;
            string t = "";
            string palavra = "";
            string palavra2 = "";

            for (int i = 0; i < texto.Length; ++i)
            {
                if (int.TryParse(texto[i].ToString(), out _) || texto[i].Equals('['))
                {
                    times.Add(texto[i]);
                    continue;
                }
                else if (texto[i].Equals(']'))
                {
                    for (int j = 0; j < times.Count - 1; ++j)
                    {
                        if (!times[j].Equals('['))
                        {
                            t += times[j];
                        }
                        else
                        {
                            break;
                        }
                    }

                    numero = Convert.ToInt32(t);

                    for (int l = 0; l < textoRepetir.Count; ++l)
                    {
                        palavra += textoRepetir[l];
                    }

                    for (int k = 0; k < numero; ++k)
                    {
                        palavra2 += palavra;
                    }
                    numero = 0;
                    t = "";
                    palavra = "";
                    times.Clear();
                    textoRepetir.Clear();
                    continue;
                }
                textoRepetir.Add(texto[i]);
            }

            if (textoRepetir.Count > 0)
            {
                for (int i = 0; i < textoRepetir.Count; i++)
                {
                    palavra2 += textoRepetir[i];
                }
            }

            Console.WriteLine(palavra2);

            return null;
        }

        private static void Times(string texto)
        {
            for (int i = 0; i < 0; i++)
            {

            }
        }
    }
}