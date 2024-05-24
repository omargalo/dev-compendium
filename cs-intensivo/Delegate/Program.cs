using System;
using System.IO;

namespace Delegate
{
    internal class Program
    {
        // Los delegados nos permiten guardar en variables funciones
        delegate int Operation(int a, int b);
        delegate void Show(string message);

        public class Functions
        {
            public static int Sum(int x, int y) => x + y;
            public static int Multiply(int num1, int num2) => num1 * num2;
            public static void ConsoleShow(string message) => Console.WriteLine(message);
            
        }
        static void Main(string[] args)
        {
            Operation mySum = Functions.Sum;

            Console.WriteLine(mySum(4,3));

            mySum = Functions.Multiply;
            Console.WriteLine(mySum(4,3));

            Show myShow = Functions.ConsoleShow;
            myShow("Hola Evelyn");
        }        
    }
}
