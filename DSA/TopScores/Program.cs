using System;

namespace TopScores
{
    class Program
    {
        static void Main(string[] args)
        {
            var scores = new int[] { 37, 89, 41, 65, 91, 53 };
            var expected = new int[] { 91, 89, 65, 53, 41, 37 };
            var actual = SortScores(scores, 100);
        }

        public static int[] SortScores(int[] unorderedScores, int highestPossibleScore)
        {
            int[] scoreCounts = new int[highestPossibleScore + 1];

            foreach (var number in unorderedScores)
            {
                scoreCounts[number]++;
            }

            int[] orderedScores = new int[unorderedScores.Length];

            int currentIndex = default;

            // Build the orderedScores array.
            for (int i = highestPossibleScore; i >= 0; i--)
            {
                int count = currentIndex + scoreCounts[i];

                for (int j = currentIndex; j < count; j++)
                {
                    orderedScores[currentIndex] = i;
                    currentIndex++;
                }
            }

            return orderedScores;
        }
    }
}
