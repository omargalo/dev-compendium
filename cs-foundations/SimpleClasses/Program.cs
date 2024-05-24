using System;

namespace SimpleClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating an instance of the Car class
            Car myCar = new Car();
            myCar.Brand = "Alfa Romeo";
            myCar.Model = "Giulia";
            myCar.Year = 2023;
            myCar.Color = "Red";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Brand,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:C}", value);

            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());

            Console.ReadLine();
        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 1305000.0M;

            return carValue;
        }
    }

    //Defining class Car
    //Defines a datatype that describes a Car
    class Car
    {
        //Properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 2020)
            {
                carValue = 900000;
            }
            else
            {
                carValue = 200000;
            }
            return carValue;
        }

    }
}