using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace LironCarDealershipReview2
{
    class test
    {
        int something { get; set; }
        public test(int something, string temp, int price)
        {
            this.something = something;
        }

        public int GetSomething()
        {
            return something;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Car class
            //Price, Year, Model, Color
            //Get Functions for them (No need for set functions)

            //List of the Car class containing x amount of cars
            int money = 200000;

            List<Car> list = new List<Car>();

            list.Add(new Car("Honda", 15000, 1998, "Civic", "Gray"));
            list.Add(new Car("Toyota", 18000, 2003, "Camary", "Matte Black"));
            list.Add(new Car("Mercedes-Benz", 90000, 2019, "Gls-450", "Peral White"));
            list.Add(new Car("BMW", 78000, 2020, "X6", "Red"));

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].GetName());
            }
            Console.WriteLine("Which Car Would You Like To View More Information On?");
            int userNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{list[userNum]}");
        }
    }
}
