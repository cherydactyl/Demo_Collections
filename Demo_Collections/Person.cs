using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Collections
{
    class Person
    {
        static int numberOfPeople;
        string lastName;
        string firstName;
        int id;

        public int Id 
        {
            get { return this.id; }
        }

        public Person()
        {
            numberOfPeople++;
            this.firstName = "Person";
            this.lastName = numberOfPeople.ToString();
            this.id = numberOfPeople;
        }
        public Person(string _name)
        {
            numberOfPeople++;
            if (_name.Contains(" "))  //if the name includes a space, assume everything before the " " is firstName
            {
                string[] names = _name.Split(' ');
                this.firstName = names[0];
                this.lastName = _name.Substring(names[0].Length +1);
            }
            else   //otherwise, set the first name to the empty string and store the name in last name
            {
                this.firstName = "";
                this.lastName = _name;
            }
            this.id = numberOfPeople;
        }
        public string name()
        {
            if (firstName.Length > 0)
            {
                return firstName + " " + lastName;
            }
            else
            {
                return lastName;
            }
        }
        public void Print()
        {
            Console.WriteLine(this.id + "\t" + this.name());
        }
    }
}
