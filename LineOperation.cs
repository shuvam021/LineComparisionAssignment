using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisionAssignment
{
    internal class LineOperation
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        public LineOperation(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public double LengthOfLine()
        {
            return Math.Sqrt(Math.Pow((this.x2 - this.x1), 2) + Math.Pow((this.y2 - this.y1), 2));
        }
        public static void CheckEqual(double val1, double val2)
        {
            Console.WriteLine($"{val1} == {val2}: {val1.Equals(val2)}"); ;
        }
        public static void Compare(double val1, double val2)
        {
            switch (val1.CompareTo(val2))
            {
                case 1:
                    Console.WriteLine($"{val1} > {val2}");
                    break;
                case -1:
                    Console.WriteLine($"{val1} < {val2}");
                    break;
                case 0:
                    Console.WriteLine($"{val1} == {val2}");
                    break;
                default:
                    Console.WriteLine("Error: somehing went wrong");
                    break;
            }
        }
    }
}
