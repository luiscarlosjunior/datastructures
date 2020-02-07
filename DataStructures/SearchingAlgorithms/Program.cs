using System;

namespace SearchingAlgorithms
{
    internal class Program
    {
        private static readonly SearchLinear sl = new SearchLinear();

        private static void Main(string[] args)
        {
            //LinearSearch();
            //BinaySearch();
            //JumpSearch();
            //InterpolationSearch();
            FibonatiSearch();
        }

        private static void LinearSearch()
        {
            int[] arr = { 1, 2, 3, 5, 6 };

            int value = 10;

            bool resultado = sl.Linear(arr, value);

            if (resultado)
            {
                Console.WriteLine("Element is not present in arr");
            }
            else
            {
                Console.WriteLine("Element is present");
            }
        }

        private static void BinaySearch()
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 10;
            int result = sl.binarySearch(arr, x);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at "
                                  + "index " + result);
        }

        private static void JumpSearch()
        {
            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 40 };
            int x = 10;
            int result = sl.JumpSearch(arr, x);

            Console.WriteLine("The number is: " + result);
        }

        private static void InterpolationSearch()
        {
            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 40 };
            int x = 10;
            int result = sl.InterpolationSearch(arr, x);

            Console.WriteLine("The number is: " + result);
        }

        private static void FibonatiSearch()
        {
            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 40 };
            int x = 10;
            int result = sl.FibonacciSearch(arr, x, arr.Length);

            Console.WriteLine("The number is: " + result);
            Console.ReadLine();
        }
    }
}