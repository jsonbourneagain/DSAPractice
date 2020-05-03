using System;

namespace InPlaceReversingOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] message = { 'c', 'a', 'k', 'e', ' ',
                       'p', 'o', 'u', 'n', 'd', ' ',
                       's', 't', 'e', 'a', 'l'};

            ReverseWords(message);
            Console.WriteLine(message);
        }

        // Question
        // Your team is scrambling to decipher a recent message, worried it's a plot to break into a major European National Cake Vault.
        // The message has been mostly deciphered, but all the words are backward! Your colleagues have handed off the last step to you.
        // Write a method ReverseWords() that takes a message as an array of characters and reverses the order of the words in place.

        //char[] message = { 'c', 'a', 'k', 'e', ' ',
        //           'p', 'o', 'u', 'n', 'd', ' ',
        //           's', 't', 'e', 'a', 'l'};

        //ReverseWords(message);

        //Console.WriteLine("{0}", new string (message));
        // prints: "steal pound cake"

        public static void ReverseWords(char[] message)
        {
            // Decode the message by reversing the words

            int leftPointer = 0;
            int rightPointer = message.Length - 1;
            Swap(message, ref leftPointer, ref rightPointer);

            // reset the left and right pointers
            leftPointer = 0;
            rightPointer = 0;

            for (int i = 0; i <= message.Length; i++)
            {
                if (i == message.Length || Char.IsWhiteSpace(message[i])) // better than reversing the last word separately.. line 57
                {
                    rightPointer = i - 1;

                    Swap(message, ref leftPointer, ref rightPointer);

                    // move left and right pointers forward to the next word
                    leftPointer = i + 1;
                    rightPointer = i;
                }
                rightPointer++;
            }

            //swap the last word left
            //rightPointer = message.Length - 1;
            //Swap(message, ref leftPointer, ref rightPointer);

        }

        private static void Swap(char[] message, ref int leftPointer, ref int rightPointer)
        {
            while (leftPointer < rightPointer)
            {
                var temp = message[leftPointer];
                message[leftPointer] = message[rightPointer];
                message[rightPointer] = temp;

                leftPointer++;
                rightPointer--;
            }
        }
    }
}
