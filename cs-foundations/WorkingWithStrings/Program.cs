using System;

namespace WorkingWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "My \"so-called\" life";
            string myString2 = "What if I need a \nnew line?";
            string myString3 = "Go to your C:\\ drive";
            string myString4 = @"Go to your D:\ drive";

            string myString5 = String.Format("{1} = {0}", "First", "Second");

            //Format for Currency
            string myString6 = String.Format("{0:C}", 123.45);

            //Add decimal points and comas to a number
            string myString7 = String.Format("{0:N}", 1234567890);

            //Display a value as a percentage
            string myString8 = String.Format("{0:P}", .921);

            //Display a custom format
            string myString9 = String.Format("Phone number: {0:(###) ###-####}", 1234567890);

            Console.WriteLine(myString);
            Console.WriteLine(myString2);
            Console.WriteLine(myString3);
            Console.WriteLine(myString4);
            Console.WriteLine(myString5);
            Console.WriteLine(myString6);
            Console.WriteLine(myString7);
            Console.WriteLine(myString8);
            Console.WriteLine(myString9);

            Console.ReadLine();
        }
    }
}