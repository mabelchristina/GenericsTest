using System;

namespace GenericTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxOfNumber maxOfNumber = new MaxOfNumber();
            Console.WriteLine(maxOfNumber.Max(10, 2, 1));
        }
    }
}
