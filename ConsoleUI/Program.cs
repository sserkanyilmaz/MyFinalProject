using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    //SOLID
    //OpenClosed Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            NorthwindContext northwindContext= new NorthwindContext();
            foreach (var product in northwindContext.Products)
            {   
                Console.WriteLine(product.ProductName);
            }
        }
    }
}