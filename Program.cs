using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Channels;

namespace first
{
    
    class Program
    {

        static long GCD(long n1, long n2)
        {
            if (n2 == 0)
            {
                
                Console.WriteLine("\n" + n1);
                return n1;
            }
            else
            {
                return GCD(n2, n1 % n2);
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                

                if (input == "END")
                {
                    Console.WriteLine("See you later :))");
                    break;
                }

                var numbers = input.Split(" ");

                var t = 
                    new Thread(
                        unused => GCD(long.Parse(numbers[0]), long.Parse(numbers[1]))
                    );
                
                t.Start();
                
                
                
            }
        }
    }
}