using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeMeetings
{
    public class Solution
    {
        public class Meeting
        {
            public int StartTime { get; set; }

            public int EndTime { get; set; }

            public Meeting(int startTime, int endTime)
            {
                // Number of 30 min blocks past 9:00 am
                StartTime = startTime;
                EndTime = endTime;
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                if (ReferenceEquals(obj, this))
                {
                    return true;
                }

                var meeting = (Meeting)obj;
                return StartTime == meeting.StartTime && EndTime == meeting.EndTime;
            }

            public override int GetHashCode()
            {
                var result = 17;
                result = result * 31 + StartTime;
                result = result * 31 + EndTime;
                return result;
            }

            public override string ToString()
            {
                return $"({StartTime}, {EndTime})";
            }
        }

        public static List<Meeting> MergeRanges(List<Meeting> meetings)
        {
            // Merge meeting ranges

            // sort the list of meetings based on the start time.

            meetings = meetings.OrderBy(m => m.StartTime).ToList();

            int startTime = meetings[0].StartTime;
            int endTime = meetings[0].EndTime;

            List<Meeting> retList = new List<Meeting>();

            int i = 0;

            while (i < meetings.Count)
            {
                if (i + 1 < meetings.Count)
                {
                    var tempStart = meetings[i + 1].StartTime;
                    var tempEnd = meetings[i + 1].EndTime;

                    if (endTime >= tempStart)
                    {
                        if (endTime < tempEnd)
                            endTime = tempEnd;
                    }
                    else
                    {
                        retList.Add(new Meeting(startTime, endTime));
                        startTime = tempStart;
                        endTime = tempEnd;
                    }
                }
                else
                    retList.Add(new Meeting(startTime, endTime));

                i++;
            }

            return retList;
        }
    }
}
