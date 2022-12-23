using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factors = 0, n1, n2, i, j;
            Console.WriteLine("please enter n1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter n2");
            n2 = int.Parse(Console.ReadLine());
            for (i = n1; i <= n2; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        factors++;
                    }
                }
                if (factors == 2)
                {
                    Console.WriteLine("the prime number is" + " " + i);
                    factors = 0;
                }
                else
                {
                    factors = 0;
                }
            }
        }
    }   }
