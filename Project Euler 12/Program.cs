using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;

namespace Project_Euler_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = 0;
            BigInteger counter = 0;
            bool Divisors = false;
            Console.WriteLine("How many divisors do you want?");
            int NumOfDivisors = Convert.ToInt32(Console.ReadLine());
            while (Divisors == false)
            {
                counter++;
                number += counter;
                if (number > 100000000)
                {
                    Divisors = Numbers(number, NumOfDivisors);
                    Console.WriteLine(number);
                }
            }
            Console.WriteLine(number);
        }
        static bool Numbers (BigInteger number, int NumOfDivisors)
        {
            int i = 0;
            int counter = 0;
            while (i < number/2)
            {
                i++;
                if (number % i == 0)
                {
                    counter++;
                }
            }
            if (counter > NumOfDivisors)
            {
                Console.WriteLine(NumOfDivisors);
                return true;

            }
            return false;
        }
    }
}
