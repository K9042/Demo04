using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class person
    {
        public string FirstName { get; set;  }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public person()
        {
        }

        public person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void PersonMethod()
        {
            Console.WriteLine("This method belongs to Person!");
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Address + " " + Age + " " + PhoneNumber;
        }
    }
}
