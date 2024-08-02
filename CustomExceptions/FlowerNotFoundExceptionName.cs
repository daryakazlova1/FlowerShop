using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.CustomExceptions
{
    public class FlowerNotFoundExceptionName : Exception
    {
        public string FlowerName { get; set; }

        public FlowerNotFoundExceptionName(string flowerName): base($"Flower with name '{flowerName}' not found.")
        {
            FlowerName = flowerName;
        }

    }
}
