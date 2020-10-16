using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Order
{
    string orderId;
    public string OrderId
    {
        get
        {
            return orderId;
        }
        set
        {
            orderId = value;
        }
    }

    string orderDate;
    public string OrderDate
    {
        get
        {
            return orderDate;
        }
        set
        {
            orderDate = value;
        }
    }

    string customerId;
    public string CustomerId
    {
        get
        {
            return customerId;
        }
        set
        {
            customerId = value;
        }
    }

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

    public Order() { }

    //Order(string orderId, string orderDate, string customerId, string productId)
    //{
    //    this.orderId = orderId;
    //    this.orderDate = orderDate;
    //    this.customerId = customerId;
    //    this.productId = productId;
    //}
}
    
