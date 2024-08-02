using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    internal class Lily : Flower
    {
        public string Fragrance { get; set; }

        public Lily(string name, string color, string fragrance, decimal price) : base(name, color, price)
        {
            this.Fragrance = fragrance;
        }
    }
}
