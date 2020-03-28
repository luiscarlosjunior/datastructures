using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerHankChallenge.Challenge
{
    class Desafios
    {
        /// https://www.hackerrank.com/challenges/staircase/problem
        /// Desafio da estrela
        /// Write a program that prints a staircase of size.
        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));
            }
        }

        ///https://www.hackerrank.com/challenges/birthday-cake-candles/problem
        ///Desafio Bolo de aniversario
        ///
        public static int birthdayCakeCandles(int[] ar)
        {
            int cont = 0;
            int max = ar.Max();

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == max)
                    ++cont;
            }

            Console.WriteLine(cont);

            return 0;
        }
        
        public static int SimpleArraySum(int[] arr)
        {
            int soma = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                soma += arr[i];
            }

            return soma;
        }

        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            List<int> answer = new List<int> { 0, 0 };

            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] > b[i])
                {
                    answer[0] += 1;
                }
                else if (a[i] < b[i])
                {
                    answer[1] += 1;
                }
            }

            return answer;
        }

        public static long aVeryBigSum(long[] arr)
        {
            long soma = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                soma += arr[i];
            }

            return soma;
        }

        public static int DiagonalDifference(List<List<int>> arr)
        {
            int somaLeft = 0;
            int somaRight = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int k = 0; k < arr.Count; k++)
                {
                    if (i == k)
                    {
                        somaLeft += arr[i][k];
                    }
                    if ((i + k) == (arr.Count - 1))
                    {
                        somaRight += arr[i][k];
                    }
                }
            }

            return Math.Abs(somaLeft - somaRight);
        }

        public static void plusMinus(int[] arr)
        {
            int[] parameters = new int[3];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    parameters[0]++;
                }
                else if (arr[i] < 0)
                {
                    parameters[1]++;
                }
                else
                {
                    parameters[2]++;
                }
            }

            float positive = (float)parameters[0] / arr.Length;
            float negative = (float)parameters[1] / arr.Length;
            float zero = (float)parameters[2] / arr.Length;

            Console.WriteLine(positive.ToString("N4"));
            Console.WriteLine(negative.ToString("N4"));
            Console.WriteLine(zero.ToString("N4"));

        }

        public static long[] selectionSort(long[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // Find the minimum element in unsorted
                long minIdx = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIdx])
                    {
                        minIdx = j;
                    }
                }
                // Swap the found minimum element with the next
                long temp = arr[minIdx];
                arr[minIdx] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
    }
}
