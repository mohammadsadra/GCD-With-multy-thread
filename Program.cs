using System;
using System.Threading;

namespace first
{
    
    class Program
    {

        static long GCD(long n1, long n2, int len)
        {
            if (n2 == 0)
            {
                Thread.Sleep(len * 1000);
                Console.WriteLine("\n" + n1);
                return n1;
            }
            else
            {
                return GCD(n2, n1 % n2, len);
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Wrong input, Try again please...");
                    continue;
                }

                if (input == "END")
                {
                    Console.WriteLine("See you later :))");
                    break;
                }

                var numbers = input.Split(" ");

                var t = 
                    new Thread(
                        unused => GCD(long.Parse(numbers[0]), long.Parse(numbers[1]), numbers[0].Length)
                    );
                
                t.Start();
                
                
                
            }
        }
    }
}