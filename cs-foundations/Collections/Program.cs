using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    //Lists and Didtionaries are the most used collections
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "Lotus";
            car1.Model = "Elise";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Brand = "Maserati";
            car2.Model = "Ghibli";
            car2.VIN = "B7";

            Book book1 = new Book();
            book1.Title = "El Extranjero";
            book1.Author = "Albert Camus";
            book1.ISBN = "0-000-00000-0";
            
            Book book2 = new Book();
            book2.Title = "Fausto";
            book2.Author = "Johann Wolfgang von Goethe";
            book2.ISBN = "0-000-00000-0";

            //The Generic List: List<T>
            //Requires that you make it specific by
            //given it the data type that should be
            //allowed inside of the collection
            
            /*
            List<Car> myCarList = new List<Car>();
            myCarList.Add(car1);
            myCarList.Add(car2);

            foreach (Car car in myCarList)
            {
                Console.WriteLine(car.Brand);
            }
            */

            //Dictionary
            //The are two components to each entry in
            //the dictionary: Key and Value
            
            //Dictionary<TKey, TValue>
            //TKey something that uniquely identifies one entity
            //inside of the dictionary like customerID
            //TValue could be of any data type
            
            /*
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B7"].Model);

            Console.ReadLine();
            */

            //Object initializer sintax
            //No need of a Constructor
            //string[] names= {"Omar", "Evelyn", "Ender", "Alex"};
            Car car3 = new Car() { Brand="BMW", Model="735li", VIN="C5" };
            Car car4 = new Car() { Brand = "Chevrolet", Model = "Cheyenne", VIN = "D9" };

            //Collection initializer
            List<Car> myList = new List<Car>()
            {
                new Car {Brand = "Mercedes Benz", Model = "C530", VIN="E6"},
                new Car {Brand = "Toyota", Model = "Camry", VIN="F8"}
            };
                
            /*
            //Deprecated:
            //ArrayLists are dynamically sized,
            //cool features like sorting, remove items
            //Downside is that it's not strong typed

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(book1);
            myArrayList.Remove(book1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Brand);
            }
            Console.ReadLine();
            */
        }
    }

    class Car
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? VIN { get; set; }
    }

    class Book
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
    }
}