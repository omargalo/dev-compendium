using System;

namespace UnderstandingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The wrong way
            /*
            int number1 = 7;
            int number2 = 3;
            int number3 = 12;
            int number4 = 8;
            int number5 = 5;

            if (number1 == 8)
            {
            }
            else if (number2 == 8)
            {
            }
            else if (number3 == 8)
            {
            }
            */

            // Arrays

            /*
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 2;
            numbers[2] = 7;
            numbers[3] = 19;
            numbers[4] = 5;

            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers.Length);
            */

            // A better way

            int[] numbers = new int[] { 7, 13, 12, 4, 19, 9 };

            string[] names = new string[] { "Evelyn", "Ender", "Alexander", "Omar" };

            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
           */

            /*
            // Using foreach
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            string quote = "You can get what you want out of line " +
                " if you hep enough other people get what they want.";

            char[] charArray = quote.ToCharArray();
            Array.Reverse(charArray);

            foreach (char quoteChar in charArray)
            {
                Console.Write(quoteChar);
            }
            Console.ReadLine();

        }
    }
}