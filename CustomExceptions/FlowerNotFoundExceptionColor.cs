using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.CustomExceptions
{
    public class FlowerNotFoundExceptionColor : Exception
    {
        public string FlowerColor { get; set; }

        public FlowerNotFoundExceptionColor(string flowerColor): base($"Flower with color '{flowerColor}' not found.")
        {
            FlowerColor = flowerColor;
        }

    }
}
