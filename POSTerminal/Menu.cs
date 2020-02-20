using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminal
{
    public class Menu
    {
        List<Product> menu = new List<Product>();
        


        private Product p;

        public Product P { get => p; set => p = value; }

        public Menu()
        {

            menu.Add(new Product("Runtz", 20, 26, "Indica"));
            //menu.Add(new Product("Dream Queen", 8, 18, "Sativa"));
            //menu.Add(new Product("Dosi Dos", 20, 28, "Sativa"));
            menu.Add(new Product("Mac 1", 20, 22, "Hybrid"));
            //menu.Add(new Product("Bermuda", 20, 23, "Sativa"));
            //menu.Add(new Product("Sherblatoo", 20, 20, "Indica"));
            //menu.Add(new Product("Thin Mints", 10, 22, "Hybrid"));
            //menu.Add(new Product("True North Collective Mimosa", 20, 26, "Hybrid"));
            //menu.Add(new Product("Purple Haze", 15, 19, "Sativa"));
            //menu.Add(new Product("Guava Cake", 20, 23, "Hybrid"));
            //menu.Add(new Product("Sour OG Kush", 10, 18, "Hybrid"));
            //menu.Add(new Product("Kush Mints", 20, 26, "Indica"));

        }

        public string PrintString()
        {
            StringBuilder sb = new StringBuilder("");
            foreach(Product p in menu)
            {
                sb.Append(p.ToString());
            }
            return sb.ToString();



        }
    }
}
