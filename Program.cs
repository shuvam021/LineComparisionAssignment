using System;

namespace LineComparisionAssignment
{
    internal class Program
    {
        public static double LengthOfLine()
        {
            Console.Write("Insert x1 = ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert y1 = ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert x2 = ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert y2 = ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"length of line is {LengthOfLine()} unit");
        }
    }
}
