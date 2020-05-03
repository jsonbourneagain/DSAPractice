using System;
using System.Linq;

namespace MergeTwoSortedArraysIntoOneArray
{
    class Program
    {
        static void Main(string[] args)
        {

            //var myArray = new int[] { 2, 4, 6, 8 };
            //var alicesArray = new int[] { 1, 7 };
            //var myArray = new int[] { };
            //var alicesArray = new int[] { };
            var myArray = new int[] { };
            var alicesArray = new int[] { 1, 2, 3 };
            //var myArray = new int[] { 5, 6, 7 };
            //var alicesArray = new int[] { };
            //var myArray = new int[] { 2, 4, 6 };
            //var alicesArray = new int[] { 1, 3, 7 };
            //var myArray = new int[] { 2, 4, 6, 8, 9,10,11 };
            //var alicesArray = new int[] { 1, 7,20 };

            var a = MergeArrays(myArray, alicesArray);

            Console.WriteLine("Hello World!");
        }

        public static int[] MergeArrays(int[] myArray, int[] alicesArray)
        {
            // Combine the sorted arrays into one large sorted array
            var mergedArray = new int[myArray.Length + alicesArray.Length];
            int myPointer = default;
            int alicesPointer = default;

            for (int i = 0; i < myArray.Length + alicesArray.Length; i++)
            {
                int headOfMyArray = default;
                int headOfAlicesArray = default;
                bool aliceHasGotNoElements = false;
                bool iHaveGotNoElements = false;

                if (myPointer < myArray.Length)
                    headOfMyArray = myArray[myPointer];
                else
                    iHaveGotNoElements = true;

                if (alicesPointer < alicesArray.Length)
                    headOfAlicesArray = alicesArray[alicesPointer];
                else
                    aliceHasGotNoElements = true;

                if (!iHaveGotNoElements && !aliceHasGotNoElements)
                {
                    if (headOfMyArray < headOfAlicesArray)
                    {
                        mergedArray[i] = headOfMyArray;
                        myPointer++;
                    }
                    else
                    {
                        mergedArray[i] = headOfAlicesArray;
                        alicesPointer++;
                    }
                }
                else if (iHaveGotNoElements)
                {
                    mergedArray[i] = headOfAlicesArray;
                    alicesPointer++;
                }
                else if (aliceHasGotNoElements)
                {
                    mergedArray[i] = headOfMyArray;
                    myPointer++;
                }
            }
            return mergedArray;
        }
    }
}
