using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //check number is positive or negative or zero
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            //check number is even or odd
            int num = 20;
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }
}