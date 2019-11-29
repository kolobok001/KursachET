using Ajax_Learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Ajax_Learning.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.PersonType = "All";
            return View();
        }

        //[HttpPost]
        //public ActionResult Index(string personType)
        //{
        //    ViewBag.PersonType = personType;
        //    return View();
        //}

        //БЫЛ ДО AJAX метод возвращающий коллекцию типа person
        //public IEnumerable<Person> GetPersons(string personType)
        //{
        //    IEnumerable<Person> persons = new[] 
        //                            { 
        //                                new Person { Name = "Иванов Иван", Type = PersonType.Student },
        //                                new Person { Name = "Петров Петр", Type = PersonType.Worker },
        //                                new Person { Name = "Иванова Мария", Type = PersonType.Student },
        //                                new Person { Name = "Петрова Ксения", Type = PersonType.Worker },
        //                                new Person { Name = "Сидоров Сидр", Type = PersonType.Student },
        //                                new Person { Name = "Сидорова Наталья", Type = PersonType.Worker },
        //                            };
        //    return personType == "All" ? persons : persons.Where(x => x.Type.ToString() == personType);
        //}

        public ActionResult GetPersons(string personType)
        {
            IEnumerable<Person> persons = new[] 
                                    { 
                                        new Person { Name = "Иванов Иван", Type = PersonType.Student },
                                        new Person { Name = "Петров Петр", Type = PersonType.Worker },
                                        new Person { Name = "Иванова Мария", Type = PersonType.Student },
                                        new Person { Name = "Петрова Ксения", Type = PersonType.Worker },
                                        new Person { Name = "Сидоров Сидр", Type = PersonType.Student },
                                        new Person { Name = "Сидорова Наталья", Type = PersonType.Worker },
                                    };
           // Thread.Sleep(1000);
            return View(personType == "All" ? persons : persons.Where(x => x.Type.ToString() == personType));
        }
    }
}
