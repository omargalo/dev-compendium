using System;
using System.Text;

namespace WorkingWithStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //This consumes a lot of memory
            string myString = "";

            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }

            Console.WriteLine(myString);
            Console.ReadLine();
            */

            //When we are going to do a lot of string concatenation we
            //should use String Builder to work with strings in a very
            //efficient manner

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();

        }
    }
}