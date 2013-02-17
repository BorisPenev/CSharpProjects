using System;
using System.Linq;
namespace CountAppearance
{
    class CountAppearance
    {
        static void PrintCount(int count)
        {
            Console.WriteLine("The number of elements is: {0}", count);
        }
        static int CountElement(int element, int[] arr)
        {
            int count = 0;
                
            foreach (int num in arr)
            {
                if (num == element)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            /*
                04. Write a method that counts how many times given
             *  number appears in given array. Write a test program
             *  to check if the method is working correctly.
             */
            Console.Write("How many elements will the array have: ");
            int numberOfElements = int.Parse(Console.ReadLine());
            Console.Write("Which element do you want to count: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements of the array: ");
            int[] array = new int[numberOfElements];
            for (int index = 0; index < numberOfElements; index++)
			{
			    array[index] = int.Parse(Console.ReadLine());
			}            
            PrintCount(CountElement(number, array));
        }
    }
}
