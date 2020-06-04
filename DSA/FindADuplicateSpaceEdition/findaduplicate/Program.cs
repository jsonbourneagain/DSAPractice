using System;
using System.Collections.Generic;

namespace findaduplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 2 };
            var expected = 2;
            var actual = FindRepeat(numbers);
        }

        public static int FindRepeat(int[] numbers)
        {
            // Find a number that appears more than once
            var numbersSeenSoFar = new HashSet<int>();

            foreach (var number in numbers)
            {
                if (numbersSeenSoFar.Contains(number))
                {
                    return number;
                }
                else
                {
                    numbersSeenSoFar.Add(number);
                }
            }

            throw new InvalidOperationException("No duplicates found.");
        }

    }
}
