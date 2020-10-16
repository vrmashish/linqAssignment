using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<Product> productList = new List<Product>();
        {
        new Product() { ProductId = "P01", ProductName = "Tv", ProductDescription = "4K Tv", ProductQuantity = 100 },
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
        new Order() { OrderId = "O01", OrderDate = "25 Oct 2020", CustomerId = "C02", ProductId = "P03" },
        new Order() { OrderId = "O02", OrderDate = "3 Aug 2020", CustomerId = "C04", ProductId = "P04" },
        new Order() { OrderId = "O03", OrderDate = "12 Oct 2020", CustomerId = "C01", ProductId = "P01" },
        new Order() { OrderId = "O04", OrderDate = "7 Sep 2020", CustomerId = "C02", ProductId = "P04" },
        new Order() { OrderId = "O05", OrderDate = "19 Sep 2020", CustomerId = "C05", ProductId = "P03" }
        };

        foreach (Product item in productList)
        {
            Console.WriteLine("\n\nProduct Id: {0}", item.ProductId);
            Console.WriteLine("Product Name: {0}", item.ProductName);
            Console.WriteLine("Product Description: {0}", item.ProductDescription);
            Console.WriteLine("Product Quantity: {0}", item.ProductQuantity);
        }

        foreach (Customer item in customerList)
        {
            Console.WriteLine("\n\nCustomer Id: {0}", item.CustomerId);
            Console.WriteLine("Customer Name: {0}", item.CustomerName);
            Console.WriteLine("Customer Address: {0}", item.CustomerAddress);
        }


    }

}

