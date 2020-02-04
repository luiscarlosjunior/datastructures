using System;
using System.Collections.Generic;

namespace DataStructures
{
    class AdjacencyList
    {
        readonly LinkedList<Tuple<int, int>>[] adjacentyList;

        public AdjacencyList(int v)
        {
            adjacentyList = new LinkedList<Tuple<int, int>>[v];

            for (int i = 0; i < adjacentyList.Length; ++i)
            {
                adjacentyList[i] = new LinkedList<Tuple<int, int>>();
            }
        }

        //Add a new edge to the linked list
        public void addEdgeAtEnd(int startVertex, int endVertex, int ind)
        {

        }
    }
}
