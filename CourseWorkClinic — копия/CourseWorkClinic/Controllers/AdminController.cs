using CourseWorkClinic.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseWorkClinic.Controllers
{
    
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        public ActionResult MainAdmin()
        {
            if ((Request.IsAuthenticated) && (System.Web.HttpContext.Current.User.IsInRole("админ")))
            {
                using (CourseWorkClinic.App_Data.ClinicEntities entities = new App_Data.ClinicEntities())
                {
                    //List<Сотрудники> model = entities.Сотрудники.Include("Врачи").Include("Специальности").ToList();
                    List<Сотрудники> model = entities.Сотрудники.Include("Врачи").ToList();
                    return View("MainAdmin", model);
                }
            }
            else
                return RedirectToAction("Index", "Home");
        }

        public ActionResult UserControl()
        {
            if ((Request.IsAuthenticated) && (System.Web.HttpContext.Current.User.IsInRole("админ")))
            {
                using (ClinicEntities entities = new ClinicEntities())
            {
                List<Пользователи> model = entities.Пользователи.ToList();
                return View(model);
            }
        }
            else
                return RedirectToAction("Index", "Home");
        }

    }
}
