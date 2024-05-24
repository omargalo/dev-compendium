using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.Design;

namespace LINQ
{
    //Lenguage Integrated Query Syntax
    //Provides a way to filter, sort and perform
    //other agregate operations on collections 
    //over data types.
    //Query Syntax
    //Method Syntax
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN = "A1", Brand = "BMW", Model = "735li", Year = 1999, StickerPrice = 2300 },
                new Car() { VIN = "B2", Brand = "Jaguar", Model = "F-Pace", Year = 2023, StickerPrice = 90000 },
                new Car() { VIN = "C3", Brand = "Nissan", Model = "Altima", Year = 2005, StickerPrice = 5000 },
                new Car() { VIN = "D4", Brand = "Lincoln", Model = "MKZ", Year = 2017, StickerPrice = 13000 },
                new Car() { VIN = "E5", Brand = "Lamborghini", Model = "Aventador", Year = 2022, StickerPrice = 99000 },
                new Car() { VIN = "A2", Brand = "BMW", Model = "335i", Year = 2000, StickerPrice = 7300 },
                new Car() { VIN = "C4", Brand = "Nissan", Model = "Sentra", Year = 2017, StickerPrice = 8000 }
            };

            //LINQ query
            /*
            var bmws = from car in myCars
                       where car.Brand == "BMW"
                       && car.Year == 1999
                       select car;
            */
            /*
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            */

            //LINQ method

            //var keyword in c# let the compiler figure it
            //out what the data type is

            //var bmws = myCars.Where(p => p.Brand == "BMW" && p.Year == 1999);
            //var orderedCars = myCars.OrderByDescending(c => c.Year);

            /*
            var firstBMW= myCars.OrderByDescending(c => c.Year).First(c => c.Brand == "BMW");
            Console.WriteLine(firstBMW.VIN);
            */

            //Aggregate and look across all the items on the list
            //Console.WriteLine(myCars.TrueForAll(c => c.Year > 1998));

            /*
            foreach (var car in bmws)
            {
                Console.WriteLine("Model: {0} VIN: {1}", car.Model, car.VIN);
            }
            */

            //A better way to the foreach above
            //Make a discount:
            /*
            myCars.ForEach(c => c.StickerPrice -= 2000);
            myCars.ForEach(c => Console.WriteLine("{0} {1:C}", c.VIN, c.StickerPrice));
            */

            //Console.WriteLine(myCars.Exists(c => c.Model == "735li"));

            //Console.WriteLine(myCars.Sum(c => c.StickerPrice));

            //Console.WriteLine(myCars.GetType());

            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(c => c.Year);
            Console.WriteLine(orderedCars.GetType());

            //Making a proyection into a new data type
            //Anonymous type

            var newCars = from car in myCars
                          where car.Brand == "BMW"
                          && car.Year == 1999
                          select new { car.Brand, car.Model };
            Console.WriteLine(newCars.GetType());

            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("Model: {0} VIN: {1}", car.Year, car.Model );
            }
            */


            Console.ReadLine();
        }        
    }
    class Car
    {
        public string? VIN { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}