
using ShoppingCart.Model;
using ShoppingCart.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShoppingCart.FakeRepositories
{
    public class FakeProductRepository : IProductRepository
    {
        public List<Product> _ListProducts;

        public FakeProductRepository()
        {
            _ListProducts = new List<Product>();
        }
        public Product Add(Product product)
        {
            _ListProducts.Add(product);
            return product;
        }

        public void Remove(Product product)
        {
            _ListProducts.Remove(product);
        }
        
        public Product GetProduct(int Id)
        {
            return _ListProducts.Where(x => x.Id == Id).FirstOrDefault();
        }
        public List<Product> GetProducts()
        {
            return _ListProducts;
        }
    }
}
