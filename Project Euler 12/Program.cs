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
                if (number > 0)
                {
                    Divisors = Numbers(number, NumOfDivisors);
                    //Console.WriteLine(number);
                }
            }
            Console.WriteLine(number);
        }
        static bool Numbers(BigInteger number, int NumOfDivisors)
        {
            int i = 0;
            int counter = 0;
            while (i < Sqrt(number))
            {
                i++;
                if (number % i == 0)
                {
                    counter++;
                }
            }
            counter++;
            //Console.WriteLine(counter);
            if (counter > NumOfDivisors)
            {
                //Console.WriteLine(NumOfDivisors);
                return true;

            }
            return false;
        }
        static BigInteger Sqrt(BigInteger n)
        {
            if (n < 0) throw new ArgumentException("Square root of negative numbers is undefined for BigInteger.");
            if (n == 0 || n == 1) return n;

            BigInteger low = 1;
            BigInteger high = n;
            while (low <= high)
            {
                BigInteger mid = (low + high) / 2;
                BigInteger midSquared = mid * mid;

                if (midSquared == n)
                    return mid;
                else if (midSquared < n)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return high; // Return the floor of sqrt(n) if n is not a perfect square

        }
    }
}
