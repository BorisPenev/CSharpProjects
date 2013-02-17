using System;

namespace LastDigit
{
    class LastDigit
    {
        static void PrintLastDigit(int number, string[] word) 
        {
            int lastDigit = number % 10;
            
                Console.WriteLine(word[lastDigit]);            
        }
        static void Main(string[] args)
        {
            /*
                03. Write a method that returns the last digit
             *  of given integer as an English word. Examples:
             *  512 -> "two", 1024 -> "four", 1239 -> "nine".
             */
            int number = int.Parse(Console.ReadLine());
            string[] words = {
                "zero", "one", "two", "three",
                "four", "five", "six",
                "seven", "eight", "nine"};
            PrintLastDigit(number, words);
        }
    }
}
