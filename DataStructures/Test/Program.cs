using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(4 / 2);
            //TestListArray();
            TestMatrix();
            Console.ReadLine();
        }

        public static void TestMatrix()
        {
            int idx = 10000;
            // Two-dimensional array.
            int[,] C = new int[10000, 10000];
            int[,] A = new int[10000, 10000];
            int[,] B = new int[10000, 10000];
            Random rand = new Random(12345);

            for (int i = 0; i < idx; i++)
            {
                for (int k = 0; k < idx; k++)
                {
                    A[i, k] = rand.Next(1, 50);
                    B[i, k] = rand.Next(5, 99);
                }
            }

            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 0; i < idx; i++)
            {
                for (int j = 0; j < idx; j++)
                {
                    for (int k = 0; k < idx; k++)
                    {
                        C[i, j] = C[i, j] + A[i, k] * B[k, j];
                    }
                }
            }
            watch.Stop();
            Console.WriteLine("Time: {0}ms ", watch.ElapsedMilliseconds / 1000);
        }

        public static void TestListArray()
        {
            List<int> list = new List<int>(600000);
            Random rand = new Random(12345);

            for (int i = 0; i < 600000; i++)
            {
                list.Add(rand.Next(5000));
            }

            int[] arr = list.ToArray();

            int chk = 0;

            Stopwatch watch = Stopwatch.StartNew();
            for (int rpt = 0; rpt < 100; rpt++)
            {
                int len = list.Count;
                for (int i = 0; i < len; i++)
                {
                    chk += list[i];
                }
            }
            watch.Stop();
            Console.WriteLine("List/for: {0}ms ({1})", watch.ElapsedMilliseconds, chk);

            chk = 0;
            watch = Stopwatch.StartNew();
            for (int rpt = 0; rpt < 100; rpt++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    chk += arr[i];
                }
            }
            watch.Stop();
            Console.WriteLine("Array/for: {0}ms ({1})", watch.ElapsedMilliseconds, chk);

            chk = 0;
            watch = Stopwatch.StartNew();
            for (int rpt = 0; rpt < 100; rpt++)
            {
                foreach (int i in list)
                {
                    chk += i;
                }
            }
            watch.Stop();
            Console.WriteLine("List/foreach: {0}ms ({1})", watch.ElapsedMilliseconds, chk);

            chk = 0;
            watch = Stopwatch.StartNew();
            for (int rpt = 0; rpt < 100; rpt++)
            {
                foreach (int i in arr)
                {
                    chk += i;
                }
            }
            watch.Stop();
            Console.WriteLine("Array/foreach: {0}ms ({1})", watch.ElapsedMilliseconds, chk);

            Console.ReadLine();


        }
    }
}
