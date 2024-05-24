using System;

namespace DatesAndTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToUniversalTime());

            Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

            Console.WriteLine(myValue.Month);

            DateTime myBirthday = new DateTime(1981,05,25);
            Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday2 = DateTime.Parse("25/05/1981");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday2);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}