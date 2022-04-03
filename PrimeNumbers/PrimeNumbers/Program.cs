using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           PrimeNumbersGeneretor.PrintPrimes(ReadingHelper.ReadInput("Enter the number of primes that you want to know: "));
           

        }
    }
}
