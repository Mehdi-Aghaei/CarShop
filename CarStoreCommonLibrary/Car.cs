using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreCommonLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public Car()
        {
            Make = "nothing yet ";
            Model = "nothing Yet";
            Price = 0.00M;
        }
        public Car(string model, string make, decimal price)
        {
            Model = model;
            Make = make;
            Price = price;
        }
        public override string ToString() => $"You Choose {Model} {Make} and price is ${Price} ";
    }
}
