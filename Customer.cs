using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Customer
{
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
    string customerName;
    public string CustomerName
    {
        get
        {
            return customerName;
        }
        set
        {
            customerName = value;
        }
    }
    string customerAddress;

    public string CustomerAddress
    {
        get
        {
            return customerAddress;
        }
        set
        {
            customerAddress = value;
        }
    }

    public Customer() { }

    //Customer(string customerId,string name,string address)
    //{
    //    this.address = address;
    //    this.name = name;
    //    this.customerId = customerId;
    //}
}
