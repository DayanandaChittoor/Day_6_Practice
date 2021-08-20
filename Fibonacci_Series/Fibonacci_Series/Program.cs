using System;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
    }
}
