using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<Product> productList = new List<Product>()
        {
        new Product() { ProductId = "P01", ProductName = "Tv", ProductDescription = "4K Tv", ProductQuantity = 45 },
        new Product() { ProductId = "P02", ProductName = "Remote", ProductDescription = "4K Tv Remote", ProductQuantity = 100 },
        new Product() { ProductId = "P03", ProductName = "SmartPhone", ProductDescription = "Android SmartPhone", ProductQuantity = 250 },
        new Product() { ProductId = "P04", ProductName = "SmartPhone Charger", ProductDescription = "4K Tv", ProductQuantity = 350 },
        new Product() { ProductId = "P05", ProductName = "Earphone", ProductDescription = "3.5mm Earphone", ProductQuantity = 200 }
        };
        
        List<Customer> customerList = new List<Customer>()
        {
        new Customer() { CustomerId = "C01", CustomerAddress = "Delhi", CustomerName = "Ashish" },
        new Customer() { CustomerId = "C02", CustomerAddress = "Delhi", CustomerName = "Nikhil" },
        new Customer() { CustomerId = "C03", CustomerAddress = "Ghaziabad", CustomerName = "Aman" },
        new Customer() { CustomerId = "C04", CustomerAddress = "Ghaziabad", CustomerName = "Deepak" },
        new Customer() { CustomerId = "C05", CustomerAddress = "Noida", CustomerName = "Saurabh" }
        };

        List<Order> orderList = new List<Order>()
        {
        new Order() { OrderId = "O01", OrderDate = "10/25/2020", CustomerId = "C02", ProductId = "P03" },
        new Order() { OrderId = "O02", OrderDate = "10/25/2020", CustomerId = "C04", ProductId = "P04" },
        new Order() { OrderId = "O03", OrderDate = "10/12/2020", CustomerId = "C01", ProductId = "P01" },
        new Order() { OrderId = "O04", OrderDate = "09/07/2020", CustomerId = "C02", ProductId = "P04" },
        new Order() { OrderId = "O05", OrderDate = "09/07/2020", CustomerId = "C05", ProductId = "P03" }
        };

        //Q1
        //foreach (Product item in productList)
        //{
        //    Console.WriteLine("\n\nProduct Id: {0}", item.ProductId);
        //    Console.WriteLine("Product Name: {0}", item.ProductName);
        //    Console.WriteLine("Product Description: {0}", item.ProductDescription);
        //    Console.WriteLine("Product Quantity: {0}", item.ProductQuantity);
        //}

        //Q2
        //foreach (Customer item in customerList)
        //{
        //    Console.WriteLine("\n\nCustomer Id: {0}", item.CustomerId);
        //    Console.WriteLine("Customer Name: {0}", item.CustomerName);
        //    Console.WriteLine("Customer Address: {0}", item.CustomerAddress);
        //}

        //Q3
        //var q3 = (from temp in productList
        //          where temp.ProductQuantity > 100
        //          select new
        //          {
        //              temp.ProductId,
        //              temp.ProductName,
        //              temp.ProductDescription,
        //              temp.ProductQuantity
        //          }
        //           ).ToList();
        //foreach(var item in q3)
        //{
        //    Console.WriteLine("\n\nProduct Id: {0}", item.ProductId);
        //    Console.WriteLine("Product Name: {0}", item.ProductName);
        //    Console.WriteLine("Product Description: {0}", item.ProductDescription);
        //    Console.WriteLine("Product Quantity: {0}", item.ProductQuantity);
        //}

        //Q4
        //var q4 = (from temp in productList
        //          where temp.ProductQuantity > 10 && temp.ProductQuantity<50
        //          select new
        //          {
        //              temp.ProductId,
        //              temp.ProductName,
        //              temp.ProductDescription,
        //              temp.ProductQuantity
        //          }
        //           ).ToList();
        //foreach (var item in q4)
        //{
        //    Console.WriteLine("\n\nProduct Id: {0}", item.ProductId);
        //    Console.WriteLine("Product Name: {0}", item.ProductName);
        //    Console.WriteLine("Product Description: {0}", item.ProductDescription);
        //    Console.WriteLine("Product Quantity: {0}", item.ProductQuantity);
        //}

        //Q5
        //var q5 = from temp in orderList
        //              //join ptemp in productList 
        //              //on temp.ProductId equals ptemp.ProductId
        //              //join ctemp in customerList
        //              //on temp.CustomerId equals ctemp.CustomerId
        //          orderby temp.OrderDate
        //          group temp by temp.OrderDate;

        //foreach (var item in q5)
        //{

        //    Console.WriteLine("Order Date(MM/DD/YYYY): {0}", item.Key);

        //    foreach (var entry in item)
        //    { Console.WriteLine("Order Id: {0}", entry.OrderId);
        //    }

        //}

        //Q6
        //var q6 = (from temp in productList
        //          orderby temp.ProductQuantity
        //          select new
        //          {
        //              temp.ProductId,
        //              temp.ProductName,
        //              temp.ProductDescription,
        //              temp.ProductQuantity
        //          }).ToList();

        //foreach (var item in q6)
        //{
        //    Console.WriteLine("\n\nProduct Id: {0}", item.ProductId);
        //    Console.WriteLine("Product Name: {0}", item.ProductName);
        //    Console.WriteLine("Product Description: {0}", item.ProductDescription);
        //    Console.WriteLine("Product Quantity: {0}", item.ProductQuantity);
        //}

        
        var q7 = (from temp in customerList
                  join otemp in orderList
                  on temp.CustomerId equals otemp.CustomerId
                  join ptemp in productList
                  on otemp.ProductId equals ptemp.ProductId
                  select new
                  {
                      temp.CustomerName,
                      ptemp.ProductName
                  }).ToList();

        foreach(var item in q7)
        {
            Console.WriteLine("Customer Name: {0}", item.CustomerName);
            Console.WriteLine("Product Name: {0}", item.ProductName);
        }
    }

}

