using System;

namespace Reverse_of_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, temp, remainder, reverse = 0;
            Console.WriteLine("Enter an integer ");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }
            Console.WriteLine("Given number is = {0}", temp);
            Console.WriteLine("Rreverse is = {0}", reverse);
            
        }
    }
}
