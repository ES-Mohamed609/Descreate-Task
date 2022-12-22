using System;

namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 =int.Parse (Console.ReadLine());
           Console.WriteLine("Enter the last number") ;
            
            int num2 =int.Parse (Console.ReadLine());
            Console.WriteLine();
  
            for (int i = num1; i <= num2; i++)
            {
                byte divisors = 0;
               for (int j = 1 ; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        divisors++;                           
                    }
                }

                if(divisors == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
