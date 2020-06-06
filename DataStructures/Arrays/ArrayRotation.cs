using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class ArrayRotation
    {

        // Função de rotação a arr[]
        static void leftRotate(int[] arr, int d, int n)
        {
            for (int i = 0; i < d; i++)
            {
                leftRotateByOne(arr, n);
            }
        }

        static void leftRotateByOne(int[] arr, int n)
        {
            int i, temp = arr[0];
            for (i = 0; i < n; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[i] = temp;
        }

        // Função de utilidade para exibir um array
        static void printArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }

    }
}
