using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork01._25._23
{
    internal class Notebook
    {
        public string Brand;
        public string Model;
        public double Price;

        public Notebook(string brand, string model, double price=0)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }
        public string ShowInfo()
        {
            return $"Brand : {Brand}\n" +
                   $"Model : {Model}\n" +
                   $"Price : {Price}  ";
        }
    }
}
