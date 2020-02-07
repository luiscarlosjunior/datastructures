using System;

namespace SearchingAlgorithms
{
    public class SearchLinear
    {
        public bool Linear(int[] arr, int x)
        {
            int count = arr.Length;

            for (int index = 0; index < count; ++index)
            {
                if (arr[index] == x)
                {
                    return true;
                }
            }
            return false;
        }

        public int binarySearchRecursive(int[] arr, int start, int end, int value)
        {
            if (end >= start)
            {
                int mid = start + (end - start) / 2;

                // If the element is present at the middle itself
                if (arr[mid] == value)
                {
                    return mid;
                }

                // If element is smaller than mid, then it can only
                // be present in left subarray
                if (arr[mid] > value)
                {
                    return binarySearchRecursive(arr, start, mid - 1, value);
                }

                return binarySearchRecursive(arr, mid + 1, end, value);
            }
            return -1;
        }

        public int binarySearch(int[] arr, int value)
        {
            int start = 0;
            int tamanho = arr.Length - 1;
            int metade;
            while (start <= tamanho)
            {
                metade = start + (tamanho - start) / 2;

                // Verifica se value está no meio
                if (arr[metade] == value)
                {
                    return metade;
                }

                if (arr[metade] < value)
                {
                    start = metade + 1;
                }
                else
                    start = metade - 1;
            }

            return -1;
        }
        public int BinarySearch(int[] arr, int start, int end, int value)
        {
            int tamanho = arr.Length - 1;
            int metade;
            while (start <= tamanho)
            {
                metade = start + (tamanho - start) / 2;

                // Verifica se value está no meio
                if (arr[metade] == value)
                {
                    return metade;
                }

                if (arr[metade] < value)
                {
                    start = metade + 1;
                }
                else
                    start = metade - 1;
            }

            return -1;
        }

        public int JumpSearch(int[] arr, int value)
        {
            int size = arr.Length;
            var step = (int)Math.Floor(Math.Sqrt(size));

            // Encontrando o bloco onde o elemento está presente
            int prev = 0;

            while (arr[Math.Min(step, size) - 1] < value)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(size));
                if (prev >= size)
                {
                    return -1;
                }
            }

            // Faz a busca linear pelo th bloco

            while (arr[prev] < value)
            {
                prev++;

                if (prev == Math.Min(step, size))
                {
                    return -1;
                }
            }

            if (arr[prev] == value)
            {
                return prev;
            }

            return -1;
        }

        public int InterpolationSearch(int[] arr, int value)
        {
            // Encontrando os indices nas duas pontas
            int idxBeging = 0;
            int idxEnd = (arr.Length - 1);
            int pos;

            while (idxBeging <= idxEnd &&
                value >= arr[idxBeging] &&
                value <= arr[idxEnd])
            {
                if (idxBeging == idxEnd)
                {
                    if (arr[idxBeging] == value) return idxBeging;
                    return -1;
                }

                //Posição provável mantendo distribuição uniforme
                pos = idxBeging + (((idxEnd - idxBeging) / (arr[idxEnd] - arr[idxBeging])) *
                                        (value - arr[idxBeging]));

                if (arr[pos] == value)
                {
                    return pos;
                }

                if (arr[pos] < value)
                {
                    idxBeging = pos + 1;
                }
                else
                {
                    idxEnd = pos - 1;
                }
            }
            return -1;
        }

        public int ExponentialSearch(int[] arr, int value)
        {
            if (arr[0] == value)
                return 0;

            int i = 1;
            while (i < arr.Length && arr[i] <= value)
            {
                i = i * 2;
            }

            return BinarySearch(arr, i / 2, Math.Min(i, arr.Length), value);
        }

        public int FibonacciSearch(int[] arr, int value, int size)
        {
            int fib2 = 0; // (m-2)'th numero de fib
            int fib1 = 1; // (m-1)'th numero de fib
            int fibNext = fib2 + fib1;

            while (fibNext < size)
            {
                fib2 = fib1;
                fib1 = fibNext;
                fibNext = fib2 + fib1;
            }

            //Marca o espaço a ser eliminado
            int offset = -1;

            // Enquanto existirem elementos a ser inpecionado.
            while (fibNext > 1)
            {
                int i = min(offset + fib2, size - 1);

                if (arr[i] < value)
                {
                    fibNext = fib1;
                    fib1 = fib2;
                    fib2 = fibNext - fib1;
                    offset = i;
                }
                else if (arr[i] > value)
                {
                    fibNext = fib2;
                    fib1 = fib1 - fib2;
                    fib2 = fibNext - fib1;
                }
                else return i;
            }

            if (fib1 == 1 && arr[offset+1] == value)
            {
                return offset + 1;
            }

            return -1;
        }

        public static int min(int x, int y)
        {
            return (x <= y) ? x : y;
        }
    }
}