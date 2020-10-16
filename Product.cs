using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Product
{
    string productId;
    public string ProductId
    {
        get
        {
            return productId;
        }
        set
        {
            productId = value;
        }
    }

    string productName;
    public string ProductName
    {
        get
        {
            return productName;
        }
        set
        {
            productName = value;
        }
    }

    string productDescription;

    public string ProductDescription
    {
        get
        {
            return productDescription;
        }
        set
        {
            productDescription = value;
        }
    }

    int productQuantity;
    public int ProductQuantity
    {
        get
        {
            return productQuantity;
        }
        set
        {
            productQuantity = value;
        }
    }
    public Product() { }

    //public  Product(string productId,string productName,string productDescription)
    //{
    //    this.productId = productId;
    //    this.productName = productName;
    //    this.productDescription = productDescription;
    //}
}
   
