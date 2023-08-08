using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Model;
using ShoppingCart.Repository;
using ShoppingCart.Repository.Interfaces;

namespace ShoppingCart.Application
{
    public class ProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product GetProduct(int Id)
        {
            return _productRepository.GetProduct(Id);
        }

        public Product AddProduct(Product product)
        {
            _productRepository.Add(product);
            return product;
        }

        public void RemoveProduct(Product product)
        {
            _productRepository.Remove(product);
        }


    }
}
