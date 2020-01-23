using PeopleReg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleReg.ViewModels
{
    public class PeopleViewModel
    {
        public PeopleViewModel()
        {
            if (people.Count == 0)
            {
                InitializePersonList();
            }

        }
        public static List<Person> people = new List<Person>();

        public List<Person> GetAllPeople()
        {
            return people;
        }

        private void InitializePersonList()
        {
            Person pers = new Person("Anders Magnusson", "000-111222", "Göteborg");
            people.Add(pers);
            pers = new Person("Peter Karlsson", "111-111222", "Gunnebo");
            people.Add(pers);
            pers = new Person("Kamilla Lundgren", "222-111222", "Alvesta");
            people.Add(pers);
        }

        public void AddPersonToList(Person p)
        {
            people.Add(p);
        }

        public bool DeletePerson(Person p)
        {
            if (people.Contains(p))
            {
                people.Remove(p);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
