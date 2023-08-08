using ShoppingCart.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShoppingCart.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public float Cost { get; set; }
        public float  Revenue { get; set; }
        public Tax Tax { get; set; }

    }
}
