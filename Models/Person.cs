using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleReg.Models
{
    public class Person
    {
        public Person()
        {

        }
        public Person(string name, string phone, string city)
        {
            Name = name;
            MobilNum = phone;
            City = city;
        }
        public string Name { get; set; }
        public string MobilNum { get; set; }
        public string City { get; set; }

    }
}
