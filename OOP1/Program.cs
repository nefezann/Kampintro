﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.Productname  = "masa";
            product1.Unitprice = 500;
            product1.Unitprice = 3;

            Product product2 = new Product {Id = 5, CategoryId =5,UnitsInStock =5, Productname="kalem" , Unitprice = 35 };
            Console.WriteLine(product2.Id);

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.Productname);





        }
    }
}
