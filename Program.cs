using System;

namespace perfect_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the first number");
            long num1 = long.Parse(Console.ReadLine());
            Console.WriteLine("please enter the last number");
            long num2 = long.Parse(Console.ReadLine());

            for (long i = num1; i <= num2; i++)
            {
                long sum = 0;
                for (long j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum = sum + j;

                }
                if (sum == i)
                    Console.WriteLine(i);
            }




        }
           
            
    }
}
