using System;
using System.Collections.Generic;
using System.Text;

namespace LineComaprison
{
    public class LengthOfLine
    {

        double lengthofline;
        public void Lenght(int X1, int X2, int Y1, int Y2)
        {
            lengthofline  = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine(lengthofline);
        }
    }
}
