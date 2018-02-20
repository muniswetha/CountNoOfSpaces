using System;

namespace CountNoOfSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Program to print number of spaces in a string------------");
            Console.WriteLine("\n");

            Console.WriteLine("Enter input string");

            var inputString = Console.ReadLine();

            Console.WriteLine("No of Spaces in {0} is: {1}", inputString, GetCountOfChars(inputString,' '));

            Console.ReadLine();

        }

        private static int GetCountOfChars(string inputString, char character)
        {
            int count = 0;

            foreach (char c in inputString)
            {
                if (c == character)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
