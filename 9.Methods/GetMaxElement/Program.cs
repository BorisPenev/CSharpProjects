using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMaxElement
{
    class Program
    {
        static int[] SortArrayAscending(int[] array)
        {
            int[] sorted = SortArrayDescending(array);
            sorted = sorted.Reverse().ToArray();
            return sorted;
        }
        static int[] SortArrayDescending(int[] array)
        {
            int maxElementIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                maxElementIndex = GetMaximalElement(array, i);
                int swap = array[maxElementIndex];
                array[maxElementIndex] = array[i];
                array[i] = swap;
            }
            return array;
        }
        static int GetMaximalElement(int[] array, int startIndex)
        {
            int maxElement = startIndex;
            for (int i = startIndex + 1; i < array.Length; i++)
            {
                if (array[maxElement] < array[i])
                {
                    maxElement = i;
                }
            }
            return maxElement;
        }
        static void PrintArray(int[] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
        static void Main()
        {
            /*
             09.Write a method that return the maximal element in a portion
             * of array of integers starting at given index. Using it write another 
             * method that sorts an array in ascending / descending order.
             */
            int[] array = { 5, 62, 37, 44, 77, 9, 11, 102, 13, 22, 36, 17 };
            PrintArray(array);
            Console.WriteLine(GetMaximalElement(array, 7));
            int[] sortedArray = SortArrayAscending(array);
            PrintArray(sortedArray);
            sortedArray = SortArrayDescending(array);
            PrintArray(sortedArray);
            Console.WriteLine();
        }
    }
}
