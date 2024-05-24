using System;

namespace HelperMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.WriteLine("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.WriteLine("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.WriteLine("In which city were you born? ");
            string bornCity = Console.ReadLine();

            DisplayResult(ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(bornCity));

            Console.WriteLine();

            DisplayResult(ReverseString(firstName) + " " +
                ReverseString(lastName) + " " +
                ReverseString(bornCity));

            Console.ReadLine();
        }

        private static string ReverseString(string message)
        {
            //string message = "Hola Evelyn";

            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            return String.Concat(messageArray);                        
        }

        private static void DisplayResult(
            string reversedFirstName,
            string reversedLastName,
            string reversedBornCity)
        {
            Console.WriteLine("Results: ");
            Console.Write(String.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedBornCity));
        }

        //Overloading

        private static void DisplayResult(string message)
        {
            Console.WriteLine("Results: ");
            Console.Write(message);
        }
    }
}