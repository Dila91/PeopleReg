using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeopleReg.Models;
using PeopleReg.ViewModels;

namespace PeopleReg.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People

        public IActionResult Index()
        {
            PeopleViewModel m = new PeopleViewModel();
            //return View(m.GetAllPeople().ToList());
            return View(PeopleViewModel.people);
        }

        public IActionResult Create()

        {
            Person m = new Person();
            return View("Create", m);
        }

        [HttpPost]
        public IActionResult Create(Person p)
        {
            PeopleViewModel m = new PeopleViewModel();
            m.AddPersonToList(p);
            return View("Index", m.GetAllPeople().ToList());
        }

        [HttpGet]

        public ActionResult Delete(string name)/*=> View(p)*/
        {
            var personToDelete = PeopleViewModel.people.Find(x => x.Name == name);
            return View(personToDelete);

        }
        

        // POST: Delete
        [HttpPost]
        public ActionResult Delete(Person p)
        {
            PeopleViewModel m = new PeopleViewModel();
            try
            {
                var personToRemove = PeopleViewModel.people.Find(x => x.Name == p.Name);
                // TODO: Add delete logic here
                m.DeletePerson(personToRemove);
                //PeopleViewModel.people.Remove(personToRemove);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index", m.GetAllPeople().ToList());
            }
        }
        //public IActionResult Filter()

        //{
        //    Person m = new Person();
        //    return View("Filter", m);
        //}
        public IActionResult Filter(string Filter)
        {
            var filteredList = PeopleViewModel.people.Where(x => x.Name.Contains(Filter));
            return View("Index", filteredList);
        }
    }
    

}
