// See https://aka.ms/new-console-template for more information

using System;
namespace MyApplication
{
    class Program
    {
        static int intMethod(int x, int y)
        {
            return x + y;
        }
        static double intMethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int integerResult = intMethod(2, 2);
            double doubleResult = intMethod(2.2, 2.2);
            Console.WriteLine("THE INTEGER`S RESULT: " + integerResult);
            Console.WriteLine("THE DOUBLE`S RESULT: " + doubleResult);
        }
    }
}

