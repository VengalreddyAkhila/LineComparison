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
            double a = line1.Length(2, 4, 8, 12);
            double b = line2.Length(2, 4, 8, 12);
            if (a == b)
            {
                Console.WriteLine("Lines Are Equal");
            }
            else
            {
                Console.WriteLine("Lines Are not Equals");
            }
        }
    }
}
