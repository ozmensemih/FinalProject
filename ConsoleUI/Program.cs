using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            // CategoryTest()
        }

        private static void CategoryTest()
        {
           /* CategoryManager categoryManeger = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManeger.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
           */
        }

        private static void ProductTest()
        {
           /* ProductManager productManeger = new ProductManager(new EfProductDal());

            var result = productManeger.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + '/' + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }   
           */
        }
    }
}
