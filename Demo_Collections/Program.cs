using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Customer> customerDictionary = new Dictionary<int, Customer>();
            Customer c1 = new Customer();
            Customer c2 = new Customer("Paul");
            customerDictionary.Add(c1.Id, c1);
            customerDictionary.Add(c2.Id, c2);

            customerDictionary[1].Print();
            customerDictionary[2].Print();

            //customerList.Add(c1);
            //customerList.Add(c2);

            //foreach (Customer element in customerList)
            //{
            //    element.Print();
            //}
            
 




            //keep console open during debugging
            Console.ReadLine();
        }
        static void testCustomer()
        {
            List<Customer> customerList = new List<Customer>();
            Customer c1 = new Customer();
            Customer c2 = new Customer("Paul");
            customerList.Add(c1);
            customerList.Add(c2);

            foreach (Customer element in customerList)
            {
                element.Print();
            }

        }
        static void testPoints()
        {
            List<Point> pointsList = new List<Point>();
            Point p1 = new Point();
            Point p2 = new Point();
            pointsList.Add(p1);
            pointsList.Add(p2);
        }
    }
}
