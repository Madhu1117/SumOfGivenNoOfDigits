using System;

namespace SumOfGivenNoOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input :");
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            int rem = 0;
            int b = a;

            while (a!=0)
            {
                rem = a % 10;
                sum = sum + rem;
                a = a / 10;
            }
            Console.WriteLine("Sum of {0} is {1}:",b,sum);
        }
    }
}
