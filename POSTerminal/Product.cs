using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminal
{
    public class Product
    {
        private string name;
        private double price;
        private double thcPercent;
        private string type;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public double ThcPercent { get => thcPercent; set => thcPercent = value; }
        public string Type { get => type; set => type = value; }

        public Product(string name, double price, double thcPercent, string type)
        {
            this.name = name;
            this.price = price;
            this.thcPercent = thcPercent;
            this.type = type;
        }

        public override string ToString()
        {
            return $"Name: {name}\nPrice: ${price}\nTHC Percent: {thcPercent}\nType: {type}";
        }
    }
}
