using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 3;
            product1.ProductName = "Kanepe";
            product1.UnitPrice = 4000;
            product1.UnitsInStock = 10;

            //yukarıdaki kodu şu şekilde de yazabilirsin
            Product product2 = new Product { Id = 2, CategoryId = 4, ProductName = "Buzdolabı", UnitPrice = 15000, UnitsInStock = 7 };


            //PascalCase - camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            
            

            
        }
    }
}
