using System;

namespace Perfect_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to check Whether Perfect or not");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine(number + " is a perfect number");

            }
            else
            {
                Console.WriteLine(number + " is not a perfect number");

            }
        }
    }
}
