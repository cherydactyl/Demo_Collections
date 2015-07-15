using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Collections
{
    class Person
    {
        static int numberOfCustomers;
        string name;
        int id;

        public int Id 
        {
            get { return this.id; }
        }

        public Person()
        {
            numberOfCustomers++;
            this.name = "Customer" + numberOfCustomers;
            this.id = numberOfCustomers;
        }
        public Person(string _name)
        {
            numberOfCustomers++;
            this.name = _name;
            this.id = numberOfCustomers;
        }
        public void Print()
        {
            Console.WriteLine(this.id + "\t" + this.name);
        }
    }
}
