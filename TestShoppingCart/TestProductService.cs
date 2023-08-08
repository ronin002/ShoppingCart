using Microsoft.VisualStudio.TestPlatform.Utilities;
using ShoppingCart.Application;
using ShoppingCart.Model;
using ShoppingCart.Models.Model;
using ShoppingCart.Repository;


using TestShoppingCart.FakeRepositories;

namespace TestShoppingCart
{
    public class Tests
    {
       

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreateOneProduct()
        {
            FakeProductRepository fakeProductRepository = new FakeProductRepository();



            /*
            Iceberg 🥬	1.55 €	15 % 1,79 €	Normal(21 %)    2.17 €
            Tomato 🍅	0.52 €	15 % 0.60 €	Normal(21 %)    0.73 €
            Chicken 🍗	1.34 €	12 % 1.51 €	Normal(21 %)    1.83 €
            Bread 🍞	0.71 €	12 % 0.80 €	First necessity(10 %)	0.88 €
            Corn 🌽	1.21 €	12 % 1.36 €	First necessity(10 %)	1.50 €
            */

            Tax taxFirst = new Tax();
            taxFirst.Description = "First necessity";
            taxFirst.Value = 0.1f;
            taxFirst.Id = 2;

            Tax taxNormal = new Tax();
            taxNormal.Description = "Normal";
            taxNormal.Value = 0.21f;
            taxNormal.Id = 2;


            Product product = new Product();
            product.NameProduct = "Iceberg";
            product.Cost = 1.55f;
            product.Revenue = 0.15f;
            product.Tax = taxNormal;

            
            ProductService sut = new ProductService(fakeProductRepository);
            Product result = sut.AddProduct(product);
            TestContext.WriteLine("output:" + fakeProductRepository._ListProducts.Count().ToString());
            //System.Diagnostics.Debug.WriteLine("output:" + fakeProductRepository._ListProducts.ToString());

            Assert.Pass("Iceberg", result.NameProduct);
        }
    }
}