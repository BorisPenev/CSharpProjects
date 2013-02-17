using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDigits
{
    class ReverseDigits
    {
        static void PrintNewNumber(string result)
        {
            Console.WriteLine("The new number is: {0}", result);
        }
        static string ReverseTheDigits(decimal number)
        {
            string numberToString = Convert.ToString(number);
            string tempString = "";
            for (int index = numberToString.Length - 1; index >= 0; index--)
            {
                tempString = tempString + numberToString[index];
            }
            return tempString;
        }
        static void Main(string[] args)
        {
            /*
             07.Write a method that reverses the digits of given decimal
             * number. Example: 256 -> 652
             */
            Console.Write("Enter number: ");
            decimal number = decimal.Parse(Console.ReadLine());
            PrintNewNumber(ReverseTheDigits(number));
        }
    }
}
