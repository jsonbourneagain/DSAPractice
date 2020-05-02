using System;

namespace InPlaceReversingOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void Reverse(char[] arrayOfChars)
        {
            var length = arrayOfChars.Length;

            // Reverse input array of characters in place
            if (arrayOfChars.Length > 0)
            {
                for (int i = 0; i < length / 2; i++)
                {
                    var temp = arrayOfChars[i];
                    arrayOfChars[i] = arrayOfChars[length - 1 - i];
                    arrayOfChars[length - 1 - i] = temp;
                }
            }
        }
    }
}
