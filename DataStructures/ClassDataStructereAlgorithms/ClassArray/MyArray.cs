using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDataStructereAlgorithms.ClassArray
{
    public class MyArray
    {
        public static int lenght { get; set; }
        public static int[] data { get; set; }
        public MyArray()
        {
            lenght = 0;
        }

        internal static int GetData(int index)
        {
            return data[index];
        }

        internal static void Push(int item)
        {
            data[lenght] = item;
            ++lenght;
        }

        internal static int Pop()
        {
            if (lenght <= 0)
                return -1;

            int lastItem = data[lenght - 1];
            --lenght;
            return lastItem;
        }

        internal static void DeleteAt(int index)
        {
            shiftItems(index);
        }

        private static void shiftItems(int index)
        {
            for (int i = index; i < lenght - 1; i++)
            {
                data[i] = data[i + 1];
            }
            lenght--;
        }
    }
}
