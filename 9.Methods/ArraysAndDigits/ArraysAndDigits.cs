using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndDigits
{
    class ArraysAndDigits
    {
        static void AddToArray(BigInteger first)
        {
            string firstString = Convert.ToString(first);
            int firstSize = firstString.Length;
            int[] array = new int[firstSize];

            for (int index = 0; index < firstSize; index++)
            {
                array[index] = Convert.ToInt32(firstString[firstSize - index - 1] - '0');
                Console.Write(array[index]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            /*
             08.Write a method that adds two positive integers
             * numbers represented as arrays of digits (each array
             * element arr[i] contains a digit; the last digit is
             * kept in arr[0]). Each of the numbers that will be added
             * could have up to 10 000 digits.
             */
            Console.WriteLine("Enter 'q' to stop.");
            BigInteger firstNumber;
            string str;
            char exit;
            do
            {
                Console.Write("Enter number: ");
                str = Console.ReadLine();
                firstNumber = BigInteger.Parse(str);
                Console.Write("The number in reverse is: ");
                AddToArray(firstNumber);    
                Console.WriteLine("Whant to stop(q)?");
                exit = (char)Console.Read();
            } while (exit != 'q');                      
        }
    }
}
