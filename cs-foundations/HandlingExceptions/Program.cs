using System;
using System.IO;

namespace HandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Repos\Notes.txt");
                Console.WriteLine(content);                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(@"There sure the name of the file is correct");
            }

            catch (Exception ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Code to finalize
                //Setting objects to null
                //Closing database connections
                Console.WriteLine("Closing application now...");
            }

            Console.ReadLine();
        }
    }
}