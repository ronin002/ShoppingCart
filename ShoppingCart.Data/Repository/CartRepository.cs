using ShoppingCart.Model;
using ShoppingCart.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repository
{
    // I a real APP I'll be use EF
    public class CartRepository : ICartRepository
    {
        private List<Cart> _ListCarts;

        public CartRepository()
        {
            _ListCarts = new List<Cart>();
        }
        public Cart Add(Cart cart)
        {
            _ListCarts.Add(cart);
            return cart;
        }

        public void Remove(Cart cart)
        {
            _ListCarts.Remove(cart);
           
        }
    }
}
