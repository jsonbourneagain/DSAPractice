using System;
using System.Collections.Generic;
using static MergeMeetings.Solution;

namespace MergeMeetings
{
    class Program
    {
        static void Main(string[] args)
        {
            var meetings = new List<Meeting>()
                {
                    new Meeting(5, 8), new Meeting(1, 4), new Meeting(6, 8)
                };
            var actual = MergeRanges(meetings);

            Console.WriteLine(Solution.MergeRanges(meetings).ToString());
        }
        //public static void Main(string[] args)
        //{
        //    TestRunner.RunTests(typeof(Solution));
        //}
    }
}
