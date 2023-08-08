﻿using ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repository.Interfaces
{
    public interface ICartItemRepository
    {
        CartItem Add (CartItem cartItem);
        void Remove (CartItem cartItem);

    }
}
