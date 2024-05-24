using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Declaration
            int x;
            int y;
            //Initialize
            x = 13;
            y = x + 23;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            //string myLastName;
            //Console.Write("Type your last name: ");
            //myLastName = Console.ReadLine();

            //A better way to initialize variables
            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello," + myFirstName + " " + myLastName);
            Console.ReadLine();
        }
    }
}