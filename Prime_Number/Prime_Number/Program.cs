using System;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check whether it is prime or not");
            int number = int.Parse(Console.ReadLine());
            int a = 0;

            for (int i=1; i<=number; i++)
            {
                if (number%i==0)
                {
                    a++; 
                }
            }
            if (a == 2)
            {
                Console.WriteLine(number + " is a Prime number");
            }
            else
            {
                Console.WriteLine(number + " is not a Prime Number");
            }
        }
    }
}
