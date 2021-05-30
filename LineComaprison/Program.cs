using System;

namespace LineComaprison
{
    class Program
    {
        static void Main(string[] args)
        {
            //length of lines
            LengthOfLine  line1 = new LengthOfLine();
            LengthOfLine  line2 = new LengthOfLine ();
            LengthOfLine line3 = new LengthOfLine();
            double a = line1.Length(2, 8, 8, 12);
            double b = line2.Length(2, 7, 8, 12);
            double c = (a.CompareTo (b));
            if (c == 0)
            {
                Console.WriteLine("Lines Are Equal");
            }
            else if (c == 1)
            {
                Console.WriteLine("Line1 is greater than Line2");
            }
            else
            {
                Console.WriteLine("line2 is grater than line1");
            }
        }
    }
}
