using System;

namespace WorkingWithSubstrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string myString = " That summer we took threes across the board ";

            //Define de start and the end position of the string
            //myString = myString.Substring(6,14);

            //All to UpperCase
            //myString = myString.ToUpper();

            //Replace one character with a different one
            //myString = myString.Replace(" ", "--");

            //Remove characters from our string
            //myString = myString.Remove(6,14);

            //Trim the trailing and preciding spaces 
            //myString = String.Format("Length before: {0} -- Lenght after: {1}",                myString.Length,myString.Trim().Length);
            //myString = myString.Trim();

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}