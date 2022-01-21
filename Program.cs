using System;

namespace LineComparisionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LineOperation line1 = new LineOperation(5, 6, 8, 9);
            LineOperation line2 = new LineOperation(6, 7, 12, 17);
            Console.WriteLine(line1.LengthOfLine());
            Console.WriteLine(line2.LengthOfLine());
            LineOperation.CheckEqual(line1.LengthOfLine(), line2.LengthOfLine());
            LineOperation.Compare(line1.LengthOfLine(), line2.LengthOfLine());
        }
    }
}
