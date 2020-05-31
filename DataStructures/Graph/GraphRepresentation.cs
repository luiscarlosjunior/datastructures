using System;
using System.Collections.Generic;

namespace Graph
{
    class GraphRepresentation
    {
        /**
         * Grafos são estrutura de dados que consistem nos seguintes componentes
         * 
         */

        // Usando de lista por 
        static void addEgde(LinkedList<int>[] adj, int u, int v)
        {
            adj[u].AddLast(v);
            adj[v].AddLast(u);
        }

        static void printGraph(LinkedList<int>[] adj)
        {
            for (int i = 0; i < adj.Length; i++)
            {
                Console.WriteLine("\nLista de vertice" + i);
                Console.Write("Head");

                foreach (var item in adj[i])
                {
                    Console.Write(" -> " + item);
                }
                Console.WriteLine();
            }
        }

    }
}
