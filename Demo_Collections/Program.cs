using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Demo_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            try
            {
                // Create an instance of StreamReader to read from a file. 
                // The using statement also closes the StreamReader. 
                using (StreamReader sr = new StreamReader("ListOfNames.txt"))
                {
                    string line;
                    // Read each line from a file; assume each line contains one name
                    while ((line = sr.ReadLine()) != null)
                    {
                        people.Add(new Person(line));
                        //Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.Write("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
            foreach (Person p in people)
            {
                p.Print();
            }

            //keep console open until ready to move on
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();

            Dictionary<string, Product> catalog= new Dictionary<string, Product>
                {
                    { "hardcover", new Product("Cold Shadows Hardcover", 24.99, "Random House") },
                    { "trade", new Product("Cold Shadows Trade Paperback", 19.99, "Random House") },
                    { "mass", new Product("Cold Shadows Mass Market Paperback", 8.99, "Random House")}
                };

            foreach (KeyValuePair<string, Product> item in catalog)
            {
                Console.Write(item.Key + ":   \t");
                item.Value.Print();
            }
            //keep console open until ready to move on
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
