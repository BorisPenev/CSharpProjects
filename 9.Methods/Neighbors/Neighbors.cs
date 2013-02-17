using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbors
{
    class Neighbors
    {
        static void CheckNeighbors(int position, int[] arr)
        {
            if ((position > arr.Length - 1) || (position < 0))
            {
                Console.WriteLine("Invalid position");
            }
            else if (position == 0)
            {
                if (arr[position] > arr[position + 1])
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if (position == arr.Length - 1)
            {
                if (arr[position] > arr[position - 1])
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if ((position > 0) && (position < arr.Length - 1))
            {
                if (arr[position] > arr[position + 1] && arr[position] > arr[position - 1])
                {
                    Console.WriteLine("True");
                }
                else 
                {
                    Console.WriteLine("False");
                }
            }
        }
        static void Main(string[] args)
        {
            /*
                05. Write a method that checks if the element at
             *  given position in given array of integers is 
             *  bigger than its two neighbors(when such exist)
             */
            Console.Write("Enter the size of the array: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            Console.Write("Check at position: ");
            int position = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the elements of the array: ");
            for (int index = 0; index < arraySize; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }
            CheckNeighbors(position, array);
        }
    }
}
