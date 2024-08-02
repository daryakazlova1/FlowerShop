using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    internal class Rose : Flower
    {
        public bool HasThorns { get; set; }
        public Rose(string name, string color, bool hasThorns, decimal price): base(name, color, price)
        {
            this.HasThorns = hasThorns;
        }
    }
}
