using System;

namespace Model.Entity
{
    public abstract class BaseSweet
    {
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public decimal Price { get; private set; }
        public KindManufacturer Manufacturer { get; private set; }
        public double Sugar { get; private set; }

        public BaseSweet() { }

        public BaseSweet(string name, double weight, decimal price, KindManufacturer manufacturer, double sugar)
        {
            Name = name;
            Weight = weight;
            Price = price;
            Manufacturer = manufacturer;
            Sugar = sugar;
        }

        public override string ToString()
        {
            return "Name: " + Name +
                   " | Weight: " + Weight +
                   " | Price: " + Price +
                   " | Manufacturer: " + Manufacturer +
                   " | Sugar: " + Sugar;

        }
    }
}