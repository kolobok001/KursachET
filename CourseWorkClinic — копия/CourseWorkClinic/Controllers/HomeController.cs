using CourseWorkClinic.App_Data;
using CourseWorkClinic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

using System.Data.Entity.Validation;


namespace CourseWorkClinic.Controllers
{
    public class JavaScriptResult : ContentResult
    {
        public JavaScriptResult(string script)
        {
            this.Content = script;
            this.ContentType = "application/javascript";
        }
    }
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        [AllowAnonymous]
        public ActionResult Index(string pageName)
        {
            if (Request.IsAuthenticated)
            {
                if (System.Web.HttpContext.Current.User.IsInRole("админ"))
                {
                    return RedirectToAction("MainAdmin", "Admin");
                }

                else if (System.Web.HttpContext.Current.User.IsInRole("регистратура"))
                {
                    return RedirectToAction("RegistrationOnly", "Account");
                }

                else if (System.Web.HttpContext.Current.User.IsInRole("расписание"))
                {
                    return RedirectToAction("SheduleOnly", "Account");
                }
            }

            if (Request.IsAjaxRequest())
            {
                if (pageName == "Главная")
                    return PartialView("IndexPage");
                else
                if (pageName == "Для льготников")
                    return PartialView("InfoPage");
                else
                if (pageName == "Контакты")
                    return PartialView("ContactPage");
                else
                if (pageName == "Расписание врачей")
                {
                    using (CourseWorkClinic.App_Data.ClinicEntities entities = new App_Data.ClinicEntities())
                    {
                        List<Расписание_врачей> model = entities.Расписание_врачей.ToList();
                        return PartialView("ShedulePage", model);
                    }
                }
                else if (pageName == "Запись на прием")
                {

                    return PartialView("AddReception");
                }



            }

            return View();
        }

        [AllowAnonymous]
        public ActionResult Schedule()
        {
            using (CourseWorkClinic.App_Data.ClinicEntities entities = new App_Data.ClinicEntities())
            {
                List<Расписание_врачей> model = entities.Расписание_врачей.ToList();
                return View(model);
            }
        }

        [AllowAnonymous]






        public ActionResult SheduleSearch(string specialitySearch, string surnameSearch)
        {
            using (ClinicEntities entities = new ClinicEntities())
            {
                var allShedule = entities.Расписание_врачей.ToList();

                if ((specialitySearch == "") && (surnameSearch != ""))
                    allShedule = entities.Расписание_врачей.Where(a => a.Фамилия.Contains(surnameSearch)).ToList();
                else if ((specialitySearch != "") && (surnameSearch == ""))
                    allShedule = entities.Расписание_врачей.Where(a => a.Специальность.Contains(specialitySearch)).ToList();
                else if ((specialitySearch != "") && (surnameSearch != ""))
                    allShedule = entities.Расписание_врачей.Where(a => a.Фамилия.Contains(surnameSearch) && a.Специальность.Contains(specialitySearch)).ToList();


                //if (allShedule.Count <= 0)
                //{
                //    return HttpNotFound();
                //}
                return PartialView(allShedule);
            }
        }



        public ActionResult AddReception()
        {



            if (Request.IsAjaxRequest())
            {


                using (ClinicEntities entities = new ClinicEntities())
                {
                    try
                    {
                        Прием newRecept = new Прием();
                        newRecept.ID_приема = Guid.NewGuid();
                        newRecept.ID_врача = Guid.Parse(Request["ID_врача"]);
                        newRecept.ID_пациента = Guid.Parse(Request["ID_пациента"]);
                        newRecept.Дата = DateTime.Parse(Request["Дата"]);
                        if (newRecept.Дата < DateTime.Today)
                        {
                            return Json(new { message = "нельзя записаться на прошедшие даты" });
                        }
                        //string week;
                        //if (newRecept.Дата.DayOfYear / 7 % 2 == 0) week = "чет"; else week = "нечет";
                        //int count = entities.Прием.Where(a => a.ID_врача == newRecept.ID_врача && a.Дата == newRecept.Дата).Count();
                        //int count2 = entities.Расписание.Where(a => a.ID_врача == newRecept.ID_врача && a.Код_дня == (int)newRecept.Дата.DayOfWeek && a.Неделя == week).Count();






                        //entities.Прием.Add(newRecept);
                        //if (count2 == 0)
                        //{
                        //    return Json(new { message = "Врач не принимает в этот день" });
                        //}
                        //if (count > 4)
                        //{
                        //    return Json(new { message = "В выбранный день мест больше нет" });
                        //}
                        entities.Прием.Add(newRecept);
                        entities.SaveChanges();

                    }


                    catch (DbEntityValidationException ex)
                    {
                        foreach (DbEntityValidationResult validationError in ex.EntityValidationErrors)
                        {
                            System.Diagnostics.Debug.Write("Object: " + validationError.Entry.Entity.ToString());
                            System.Diagnostics.Debug.Write(" ");
                            foreach (DbValidationError err in validationError.ValidationErrors)
                            {
                                System.Diagnostics.Debug.Write(err.ErrorMessage + " ");
                            }
                        }
                        return Json(new { message = "Произошла непредвиденная ошибка" });
                    }

                    return Json(new { message = "Успешно записали на прием" });
                }
            }
            else return View();


        }
    }

}


