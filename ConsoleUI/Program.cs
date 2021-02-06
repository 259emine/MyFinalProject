using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle yani ben  yeni bir yazılım  özellik eklediğimden mevcuttaki hiç bir koda dokunazmasın
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfproductDal());

            foreach (var product in productManager.GetByUnitPrice(40,100)) 
            {
                Console.WriteLine(product.ProductName);
            }

            
        }
    }
}
