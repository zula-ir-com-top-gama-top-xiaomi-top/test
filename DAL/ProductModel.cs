using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductModel
    {
        public string Title { get; set; }
        public short Count { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
    }
}
