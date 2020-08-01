using System;
using System.Globalization;
using System.Threading;

namespace first
{
    
    class Program
    {

        static long GCD(long n1, long n2, int len, long n3, long n4)
        {
            try
            {
                if (n2 == 0)
                {
                    Thread.Sleep(len * 1000);
                    Console.WriteLine("\nGCD of " + n3 +" & "+ n4+ " is: "+n1);
                    
                    return n1;
                }
                else
                {
                    return GCD(n2, n1 % n2, len, n3, n4);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("wrong input");
                return 0;
            }
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("GUIDE:");
            Console.WriteLine("1.You must enter two integer number then this application will help you to compute GCD of these numbers");
            Console.WriteLine("2.When you write -END-, application will be closed");
            Console.WriteLine("Enjoy :))\n");
            
            while (true)
            {
                Console.WriteLine("Enter two numbers:");
                
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

                try
                {
                    var numbers = input.Split(" ");
                    var a = long.Parse(numbers[0]) + long.Parse(numbers[1]);
                   
                    


                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("Wrong input, Try again please...\n");
                    continue;
                    
                }
                catch (System.IndexOutOfRangeException e)
                {
                    Console.WriteLine("Wrong input, Try again please...\n");
                    continue;
                }
                var numbers1 = input.Split(" ");
                var t =
                    new Thread(
                        unused => GCD(long.Parse(numbers1[0]), long.Parse(numbers1[1]), numbers1[0].Length, long.Parse(numbers1[0]), long.Parse(numbers1[1]))
                    );
                t.Start();
                
            }
        }
    }
}