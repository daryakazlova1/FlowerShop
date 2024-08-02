using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    internal class Flower
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

        public Flower(string name, string color, decimal price)
        {
            this.Name = name;
            this.Color = color;
            this.Price = price;
        }


    }
}
