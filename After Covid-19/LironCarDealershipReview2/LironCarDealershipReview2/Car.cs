using System;
using System.Collections.Generic;
using System.Text;

namespace LironCarDealershipReview2
{
    class Car
    {
        string name;
        int price;
        int year;
        string model;
        string color;

        public Car(string name, int price, int year, string model, string color)
        {
            this.name = name;
            this.price = price;
            this.year = year;
            this.model = model;
            this.color = color;
        }

        public string GetName()
        {
            return name;
        }

        public int GetPrice()
        {
            return price;
        }

        public int GetYear()
        {
            return year;
        }

        public string GetModel()
        {
            return model;
        }

        public string GetColor()
        {
            return color;
        }

    }
}
