using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishShop.Core.Entities
{
    public class Product
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string BasePrice { get; set; }

        public string SalePrice { get; set; }

    }
}
