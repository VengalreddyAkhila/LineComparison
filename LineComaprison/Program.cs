using System;

namespace LineComaprison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LineComparision");
            LengthOfLine  length = new LengthOfLine(4, 6, 8, 10);
            Console.WriteLine(length);
            
        }
    }
}
