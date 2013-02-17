using System;

namespace IntroduceYourself
{
    class IntroduceYourself
    {
        static void PrintName(string name) 
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main(string[] args)
        {
            /*
                01. Write a method that asks the user for his name
             *  and prints "Hello, <name>"(for example, "Hello, Peter!").
             *  Write a program to test this method.
             */
            string name = Console.ReadLine();
            PrintName(name);
        }
    }
}
