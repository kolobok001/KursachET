using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UsingEF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //для того, чтобы вывести всех сотрудников
            //создадим объект класса репозиторий
            EFStaffRepository repository = new EFStaffRepository();

            IEnumerable<Сотрудники> model = repository.GetStaff();
            Сотрудники person = model.ElementAt(0);
            return View(model);
        }

    }
}
