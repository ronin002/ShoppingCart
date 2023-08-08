﻿using ShoppingCart.Model;
using ShoppingCart.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repository
{
    // I a real APP I'll be use EF
    public class CartItemRepository : ICartItemRepository
    {
        private List<CartItem> _ListCartItem { get; set; }

        public CartItemRepository()
        {
            _ListCartItem = new List<CartItem>();
        }
        public CartItem Add(CartItem cartItem)
        {
            _ListCartItem.Add(cartItem);
            return cartItem;

        }

        public void Remove(CartItem cartItem)
        {
            _ListCartItem.Remove(cartItem);
        }
    }
}
