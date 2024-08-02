using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FlowerShop.CustomExceptions
{
    public class FlowerNotFoundExceptionPrice : Exception
    {
        public FlowerNotFoundExceptionPrice() :base($"No flowers found within this price range.")
        {
            
        }

    }
}
