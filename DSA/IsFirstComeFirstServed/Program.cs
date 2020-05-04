using System;

namespace IsFirstComeFirstServed
{
    class Program
    {
        static void Main(string[] args)
        {
            //var takeOutOrders = new int[] { 1, 4, 5 };
            //var dineInOrders = new int[] { 2, 3, 6 };
            //var servedOrders = new int[] { 1, 2, 3, 4, 5, 6 };

            var takeOutOrders = new int[] { 1, 9 };
            var dineInOrders = new int[] { 7, 8 };
            var servedOrders = new int[] { 1, 7, 8 };

            var result = IsFirstComeFirstServed(takeOutOrders, dineInOrders, servedOrders);
            Console.WriteLine("Hello World!");
        }

        public static bool IsFirstComeFirstServed(int[] takeOutOrders, int[] dineInOrders, int[] servedOrders)
        {
            // Check if we're serving orders first-come, first-served

            int dineInPointer = default, takeOutPointer = default, serverdPointer = default;

            while (serverdPointer < servedOrders.Length)
            {
                int servedOrder = servedOrders[serverdPointer];
                int headOfDineInOrders = default;
                int headOfTakeOutOrders = default;

                if (dineInPointer < dineInOrders.Length)
                {
                    headOfDineInOrders = dineInOrders[dineInPointer];
                }
                if (takeOutPointer < takeOutOrders.Length)
                {
                    headOfTakeOutOrders = takeOutOrders[takeOutPointer];
                }

                if (servedOrder == headOfDineInOrders)
                {
                    dineInPointer++;
                }
                else if (servedOrder == headOfTakeOutOrders)
                {
                    takeOutPointer++;
                }
                else
                    return false;

                serverdPointer++;
            }

            return true;
        }
    }
}
