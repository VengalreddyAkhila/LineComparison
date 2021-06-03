using System;

namespace LineComaprison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LineComparision");
            LengthOfLine  length = new LengthOfLine();
            double Line1 = length.Line(1, 2, 3, 2);
            double Line2 = length.Line(1, 2, 4, 6); 

            //Lines Equals
            if (Line1  == Line2 )
                Console.WriteLine("lines are equal");
            else
               Console.WriteLine("lines are not equal");
                        
            //compare lines
            if (Line1.CompareTo(Line2) == 0)
                Console.WriteLine("Both Line are  equal");
            else
                Console.WriteLine("They are not equal");
        }
    }
}
