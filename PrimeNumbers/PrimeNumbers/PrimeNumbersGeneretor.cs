using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public static class PrimeNumbersGeneretor
    {

        private static IEnumerable<int> Generate()
        {
            yield return 2;
            List<int> primesList = new List<int>() { 2 };
            
            int count = 3;

            while (true)
            {
                bool check = true;
                foreach (int prime in primesList)
                {
                    if (count % prime == 0)
                    {
                        check = false;
                        break;
                    }
 
                }


                if (check)
                {
                    yield return count;
                    primesList.Add(count);
                }
                

                count++;

            }
        }

        public static void PrintPrimes(int? n)
        {

            if (n is null || n <= 0)
            {
                Console.WriteLine($"No input number. Program has ended.");
                return;
            }
            

            Console.WriteLine($"The first {n} prime numbers are: ");
            foreach (int number in Generate())
            {
                Console.Write($"{number}, ");
                n--;

                if (n == 0) break;
            }
        }

    }
}
