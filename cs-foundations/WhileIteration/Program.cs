using System;

namespace WhileIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            //while (displayMenu == true)
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }            
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Select an option:");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");
            string selectedOption = Console.ReadLine();

            if(selectedOption == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (selectedOption == "2")
            {
                GuessingGame();
                return true;
            }
            else if (selectedOption == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print Numbers");
            Console.WriteLine("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter <= result)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1,11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();
                guesses++;

                if (result == randomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
            } while (incorrect);
            {
                Console.WriteLine("Correct! It took you {0} guesses.", guesses);
            }
            Console.ReadLine();
        }
    }
}