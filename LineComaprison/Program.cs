using System;

namespace LineComaprison
{
    class Program
    {
        static void Main(string[] args)
        {

            LengthOfLine  line1 = new LengthOfLine();
            LengthOfLine  line2 = new LengthOfLine ();
            double a = line1.Length(3, 7, 10, 12);
            double b = line2.Length(5, 7, 10, 12);
            if (a == b)
            {
                Console.WriteLine("lines are equal");
            }
            else
            {
                Console.WriteLine("lines are not equal");
            }
        }
    }
}
