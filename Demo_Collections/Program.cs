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
                using (StreamReader sr = new StreamReader(@"C:\Users\Cheryl\Documents\Visual Studio 2013\Projects\Demo_Collections\Demo_Collections\ListOfNames.txt"))
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

            //keep console open during debugging
            Console.ReadKey();
        }
    }
}
