using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Represention
{
    class Matrix
    {
        static void addEgde(LinkedList<int>[] adj,
            int u, int v)
        {
            adj[u].AddLast(v);
            adj[v].AddLast(u);
        }

        static void printGraph(LinkedList<int>[] adj)
        {
            for (int i = 0; i < adj.Length; i++)
            {
                Console.WriteLine("\nLista de vertice adjacente");
                Console.WriteLine("head");
                foreach(var item in adj[i])
                {
                    Console.Write(" -> " + item);
                }
                Console.WriteLine();
            }
        }

    }
}
