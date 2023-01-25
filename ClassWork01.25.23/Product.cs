using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork01._25._23
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int DiscountPerson;

        public Product(string name,double price , int discountPerson = 0)
        {
            Name = name;
            Price = price;
            DiscountPerson = discountPerson;
        }
    }
}
