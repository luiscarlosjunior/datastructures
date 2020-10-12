using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {

            int A;
            int B;
            int aux;

            A = 5;
            B = 7;

            Console.WriteLine("Antes da troca o valor A era: " + A
                + " e o B era: " + B);

            // Armazendo temporariamente
            aux = A;

            A = B;
            B = aux;

            Console.WriteLine("Agora o A é " + A + " e o B é " + B);

        }
    }
}
