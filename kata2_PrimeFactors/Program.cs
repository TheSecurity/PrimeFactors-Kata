using System;
using System.Collections.Generic;
using System.Linq;

namespace kata2_PrimeFactors
{
    public class Program
    {
        private static void Main()
        {
            Console.Write("Insert number: ");
            if (!int.TryParse(Console.ReadLine(), out var number)) return;

            var output = Generate(number);
            Console.WriteLine("Prime factors: " + string.Join(", ", output));
            Console.ReadKey();
        }

        public static List<int> Generate(int number = 0)
        {
            var primeNumbers = new List<int>();
            if (number <= 0) return primeNumbers;

            for (var i = 2; i <= number; i++)
            {
                if (number % i != 0) continue;
                primeNumbers.Add(i);
                number /= i;
                i = 1;
            }

            if(!primeNumbers.Any()) primeNumbers.Add(number);

            return primeNumbers;
        }
    }
}
