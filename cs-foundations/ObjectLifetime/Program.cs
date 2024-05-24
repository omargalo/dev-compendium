using System;
using System.ComponentModel.DataAnnotations;

namespace ObjectLifetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Brand = "Lamborghini";
            myCar.Model = "Aventador";
            myCar.Year = 2023;
            myCar.Color = "Green";

            //By Reference
            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Brand,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "Murcielago";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Brand,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            myOtherCar = null;

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}