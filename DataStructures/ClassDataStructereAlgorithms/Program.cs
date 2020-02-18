using ClassDataStructereAlgorithms.ClassArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDataStructereAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = new MyArray();
            int[] a = {1, 4, 5, 7 }, b = { 2, 3, 4, 5, 6};


            MergeSortedArray(a, b);

            ReverseString("Texto exemplo");
        }

        private static void ReverseString(string array)
        {
            //Option 1
            char[] str = array.ToCharArray();
            string reverseText = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseText += str[i];
            }
            Console.WriteLine(reverseText);
            

            //option2
            Console.WriteLine(array.Reverse());
            Console.ReadLine();

            //option3
            
        }

        //merge two array and sorted
        private static void MergeSortedArray(int[] array1, int[] array2)
        {
            int[] c = new int[array1.Length + array2.Length];
            
            for (int i = 0; i < c.Length; i++)
            {

            }
        }
    }
}
