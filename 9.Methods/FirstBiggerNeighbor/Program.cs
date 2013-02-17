using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBiggerNeighbor
{
    class Program
    {
        static int FindFisrtElemBiggerThanItsNeighbors(int[] arr, int length)
        {
            int element = -1;
            for (int i = 1; i < length - 1; i++)
            {
                if (arr[i] > arr[i - 1] + arr[i + 1])
                {
                    element = i;
                    return element;
                }
            }
            return element;
        }
        static void Main(string[] args)
        {
            /*
             06.Write a method that returns the index of the first element in array
             * that is bigger than its neighbors, or -1, if there’s no such element.
             * Use the method from the previous exercise.
            */
            Console.Write("Enter the size of the array: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];

            Console.WriteLine("Enter the elements of the array: ");
            for (int index = 0; index < arraySize; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }
            
            int firstelement = FindFisrtElemBiggerThanItsNeighbors(array, arraySize);
            if (firstelement != -1)
            {
                Console.WriteLine("The index of first element wich is bigger than its neighbors is:[{0}]", firstelement);
            }
            else
            {
                Console.WriteLine("There is no such element");
            }
        }
    }
}
