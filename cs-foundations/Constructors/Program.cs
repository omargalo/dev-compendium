using System;

namespace Constructors
{
    //A Constructor is a method that allow us to
    //excecute code at the moment that a new
    //instance of a class is created.
    internal class Program
    {
        //static means that you don't have to
        //create an instance of the class in
        //order to utilize that method.
        static void Main(string[] args)
        {            
            Car myCar = new Car();

            Car.MyMethod();

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Brand,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            Car mySecondCar = new Car();
            
            Console.WriteLine("{0} {1} {2} {3}",
                mySecondCar.Brand,
                mySecondCar.Model,
                mySecondCar.Year,
                mySecondCar.Color);

            //Initialize by callign the overloading constructor
            Car myThirdCar = new Car("Ford", "F-150", 2005, "Sand");
            Console.WriteLine("{0} {1} {2} {3}",
                myThirdCar.Brand,
                myThirdCar.Model,
                myThirdCar.Year,
                myThirdCar.Color);
        }
    }
    class Car
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public string? Color { get; set; }

        //Constructors are typically used in
        //order to put the new object into a
        //valid state (initialize the values
        //of the proporties of that given object)
        //so it's inmediatly usable.
        public Car()
        {
            //The word: this is optional
            //You could load from a configuration file,
            //a database, etc.
            this.Brand = "Honda";
            this.Model = "Civic";
            this.Year = 2023;
            this.Color = "Blue";
        }

        //Overloaded Constructors
        public Car(string brand, string model, int year, string color)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
        }

        public static void MyMethod()
        {
            Console.WriteLine("Called my static method");
        }
    }
}