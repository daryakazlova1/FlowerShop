using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    internal class Sunflower : Flower
    {
        public double Height { get; set; }

        public Sunflower(string name, string color, double height, decimal price) : base(name, color, price)
        {
            this.Height = height;
        }
    }
}
