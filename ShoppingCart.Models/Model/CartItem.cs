
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    public class CartItem
    {
        
        public int Id { get; set; }
        public int CartId { get; set; }
        public int Quatity { get; set; }
        public int ProductId { get; set; }
        public float PriceWithVat { get; set; }

    }
}
