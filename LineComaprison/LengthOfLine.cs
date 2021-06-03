using System;
using System.Collections.Generic;
using System.Text;

namespace LineComaprison
{
     abstract class Length
     {
        public abstract double  Line(double X1, double X2, double Y1, double Y2);
     }
    class LengthOfLine : Length
    {
        public override double Line(double X1, double X2, double Y1, double Y2)
        {
            double lengthofline = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine(lengthofline);
            return lengthofline;
        }
    }
}
