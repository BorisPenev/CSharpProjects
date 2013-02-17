using System;

namespace ReturnMax
{
    class ReturnMax
    {
        static void PrintMax(int max)
        {
            Console.WriteLine("The biggest number is: {0}", max);
        }
        static int GetMax(int firstNum, int secondNum)
        {
            int biggest = firstNum;

            if (biggest < secondNum)
            {
                biggest = secondNum;
            }
            return biggest;
        }
        static void Main(string[] args)
        {
            /*
                02. Write a method GetMax() with two parameters that
             *  returns the bigger of two integers. Write a program
             *  that reads 3 integers from the console and prints the
             *  biggest of them using the method GetMax().
             */
            int number = int.Parse(Console.ReadLine());
            int maxNum = number;

            for (int index = 0; index < 2; index++)
            {
                number = int.Parse(Console.ReadLine());
                maxNum = GetMax(maxNum, number);
            }
            PrintMax(maxNum);
        }
    }
}
