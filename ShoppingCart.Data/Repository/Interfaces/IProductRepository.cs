using ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repository.Interfaces
{
    public interface IProductRepository
    {
        Product Add(Product product);
        void Remove(Product product);
        Product GetProduct(int Id);
        List<Product> GetProducts();
    }
}
