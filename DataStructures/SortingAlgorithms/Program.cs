using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {          
            int[][] samples = new int[9][];
            samples[0] = new[] { 1 };
            samples[1] = new[] { 2, 1, 3 };
            samples[2] = new[] { 2, 1, 2, 2, 3 };
            samples[3] = new[] { 5, 4, 2, 3, 6, 7 };
            samples[4] = new[] { 5, 4, -2, 3, -6, -7 };
            samples[5] = new[] { 5, 4, 2, 3, 6, 7, -9, 1001, -1001 };
            samples[6] = new[] { -1, 1, 0, 0 };
            samples[7] = new[] { 5, 6, 9, 1, 10, 20, 2, 1, 5, 7 };
            samples[8] = new[] { 1, 5, 6, -9, -8, -4, -1, -3, 5, 0 };

            Sorting.BubbleSort(samples[2]);

        }
    }
}
