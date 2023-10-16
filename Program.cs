using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve_of_Eratosthenes
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter an integer n greater than 2: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 2)
            {
                List<int> primes = FindPrimesInRange(n);
                Console.WriteLine("Prime numbers in the range [2, " + n + "]: ");
                foreach (int prime in primes)
                {
                    Console.Write(prime + " ");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid integer greater than 2.");
            }
            Console.ReadLine();
        }

        static List<int> FindPrimesInRange(int n)
        {
            List<int> primes = new List<int>();
            for (int number = 2; number <= n; number++)
            {
                if (IsPrime(number))
                {
                    primes.Add(number);
                }
            }
            return primes;
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}

