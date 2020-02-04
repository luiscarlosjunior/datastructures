using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Graph
    {
        //number of vertices
        private readonly int V;

        //Vetor of list for adjacenty list
        private readonly List<int>[] adj;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="v">numbers of vertices</param>
        public Graph(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<int>();
            }
        }

        ///Function to add an edge into the graph
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w); // Add w to v's list
        }

        public void DFSInsert(int v, bool[] visited)
        {
            //Mark the current node as visited
            //and print it
            visited[v] = true;
            Console.WriteLine(v + " ");

            List<int> vList = adj[v];
            foreach (var item in vList)
            {
                if (!visited[item])
                {
                    DFSInsert(item, visited);
                }
            }
        }

        public void DFS(int v)
        {
            //Mark all vertices as not visited
            bool[] visited = new bool[V];

            //Call the recursion
            DFSInsert(v, visited);
        }
    }
}
