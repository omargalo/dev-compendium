using System;

namespace ForIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("Found number seven!");
                    break;
                }
            }
                        
            Console.ReadLine();
        }
    }
}