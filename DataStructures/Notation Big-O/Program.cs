using System;

namespace Notation_Big_O
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Luis", "Roberto", "Carla", "Lais", "Helena", "Cristina", "Juliano" };

            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i].Equals("Lais"))
                {
                    Console.WriteLine($"Olá, {nomes[i]}");
                }
            }
            
        }
    }
}
