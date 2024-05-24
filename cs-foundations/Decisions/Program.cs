using System;

namespace Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Evelyn's Great Giveaway");
            Console.WriteLine("Choose a door: 1, 2 or 3: ");
            string userValue=Console.ReadLine();

            //Refactor

            string message = "";

            if (userValue == "1")
            {
                message = "You won a new car!";                
            }
            else if (userValue == "2")
            {
                message = "You won a new bicycle!";                
            }
            else if (userValue == "3")
            {
                message = "You won a new Nintendo Switch!";                
            }
            else
            {
                message = "Sorry, you did not choose a valid option, ";
                //message = message + "Try again!";
                message += "Try again!";
            }

            Console.WriteLine(message);
            Console.ReadLine();
            */

            //Evaluating just 2 options

            Console.WriteLine("Evelyn's Great Giveaway");
            Console.WriteLine("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "Car" : "Piñata";

            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");

            //Usin Replacement Code
            //Console.WriteLine("You won a {0}.", message);
            Console.WriteLine("You choose: {0}, therefore you won a {1}!", userValue, message);

            Console.ReadLine();


            //Verbose way
            /*
            if(userValue == "1")
            {
                string message = "You won a new car!";
                Console.WriteLine(message);
            }
            else if(userValue == "2")
            {
                string message = "You won a new bicycle!";
                Console.WriteLine(message);
            }
            else if(userValue == "3")
            {
                string message = "You won a new Nintendo Switch!";
                Console.WriteLine(message);
            }
            else
            {
                string message = "Sorry, you did not choose a valid option";
                Console.WriteLine(message);
            }

            Console.ReadLine();
            */
        }
    }
}