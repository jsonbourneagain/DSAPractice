using System;
using System.Linq;

namespace findaduplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            // var numbers = new int[] { 1, 2, 3, 2 };
            // var expected = 2;
            // var numbers = new int[] { 1, 2, 5, 5, 5, 5 };
            // var expected = 5;
            var numbers = new int[] { 4, 1, 4, 8, 3, 2, 7, 6, 5 };
            var expected = 4;
            var actual = FindRepeat(numbers);
        }

        public static int FindRepeat(int[] numbers)
        {
            // Find a number that appears more than once

            // we're cutting our range 1..n in parts in every iteration, not the input array.
            int floor = 1;

            // Because length of the array is n+1, so to make it n we subtract 1.
            int ceiling = numbers.Length - 1;

            while (floor < ceiling)
            {
                // Divide the array into upper and lower range such that these ranges don't overlap.
                // lower range is floor to midpoint
                // upper range is midpoint+1 to ceiling

                int midpoint = (floor + ceiling) / 2;
                int lowerRangeFloor = floor;
                int lowerRangeCeiling = midpoint;
                int upperRangeFloor = midpoint + 1;
                int upperRangeCeiling = ceiling;

                int numberOfItemsInLowerRange = numbers.Count(n => n >= lowerRangeFloor && n <= lowerRangeCeiling);
                int numberOfDistinctPossibleItemsInLowerRange = lowerRangeCeiling - lowerRangeFloor + 1;

                if (numberOfItemsInLowerRange > numberOfDistinctPossibleItemsInLowerRange)
                {
                    // There must be a duplicate item in the lower range floor.
                    // keep cutting it into half iteratively.
                    floor = lowerRangeFloor;
                    ceiling = lowerRangeCeiling;
                }
                else
                {
                    // There must be a duplicate item in the lower range floor.
                    // keep cutting it into half iteratively.
                    floor = upperRangeFloor;
                    ceiling = upperRangeCeiling;
                }
            }
            // floor and ceiling have converged. We've found the duplicate number.
            return floor;
        }

    }
}
