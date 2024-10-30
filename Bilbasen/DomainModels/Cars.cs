using System;

namespace Bilbasen
{
    public class Car
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public string Color { get; private set; }
        public int HorsePower { get; private set; }

        public Car(string brand, string model, int year, string color, int horsePower)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            HorsePower = horsePower;
        }
    }
}
