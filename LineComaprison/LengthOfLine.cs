using System;
using System.Collections.Generic;
using System.Text;

namespace LineComaprison
{
    public class LengthOfLine
    {
        public double  Length(double X1, double X2, double Y1, double Y2)
        {
            //double a;
           // double b;
            double lengthofline  = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine(lengthofline);
            return lengthofline;
 
           
        }
    }
}
