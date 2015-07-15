using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Collections
{
    class Product
    {
        string description;
        double cost;
        string manufacturer;    //manufacturer might be better modeled as a class of its own, but start with a string

        public Product()
        {
            description = "";
            cost = 0;
            manufacturer = "unknown";
        }
        public Product(string d, double c, string m)
        {
            description = d;
            cost = c;
            manufacturer = m;
        }
        public void Print()
        {
            Console.WriteLine("{0}, made by {2}, {1:c}", description, cost, manufacturer );
        }
    }
}
