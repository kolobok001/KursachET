using CourseWorkClinic.App_Data;
using CourseWorkClinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CourseWorkClinic.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model, string returnUrl)
        {
            // Lets first check if the Model is valid or not
            if (ModelState.IsValid)
            {
                using (App_Data.ClinicEntities entities = new App_Data.ClinicEntities())
                {
                    string username = model.UserName;
                    string password = model.Password;

                    bool userValid = entities.Пользователи.Any(user => user.login == username);

                    if (userValid)
                    {
                        var query = entities.Пользователи.Where(x => x.login == model.UserName).Select(x => new { pass = x.password, role = x.role }).First();
                        if (query.pass == model.Password) // User found in the database
                        {
                            FormsAuthentication.SetAuthCookie(username, false);

                            if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                                && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                            {
                                return Redirect(returnUrl);
                            }
                            else
                            {
                                if (query.role == "админ")
                                {
                                    return RedirectToAction("MainAdmin", "Admin");
                                }
                                else if (query.role == "регистратура") return RedirectToAction("RegistrationOnly", "Account");
                                else if (query.role == "расписание") return RedirectToAction("SheduleOnly", "Account");
                                //return RedirectToAction("Index", "Home");
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("", "The user name or password provided is incorrect.");
                        }
                    }
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }


        public ActionResult RegistrationOnly()
        {
            return View();
        }
        public ActionResult ReceptPage()
        {
            using (CourseWorkClinic.App_Data.ClinicEntities entities = new App_Data.ClinicEntities())
            {
                List<ReceptionAtDoctor> model = (from Прием in entities.Прием
                                                 join Пациенты in entities.Пациенты on Прием.ID_пациента equals Пациенты.ID_пациента
                                                 join Врачи in entities.Врачи on Прием.ID_врача equals Врачи.ID_врача
                                                 join Сотрудники in entities.Сотрудники on Врачи.ID_сотрудника equals Сотрудники.ID_сотрудника
                                                 let p = new ReceptionAtDoctor
                                                 {
                                                     ID_приема = Прием.ID_приема,
                                                     ID_врача = Прием.ID_врача,
                                                     ID_пациента = Прием.ID_пациента,
                                                     ф_врача = Сотрудники.Фамилия,
                                                     и_врача = Сотрудники.Имя,
                                                     о_врача = Сотрудники.Отчество,
                                                     ф_пациента = Пациенты.Фамилия,
                                                     и_пациента = Пациенты.Имя,
                                                     о_пациента = Пациенты.Отчество,
                                                     Дата_приема = Прием.Дата,
                                                     Диагноз = Прием.Диагноз,
                                                     Рецепт = Прием.Рецепт,
                                                     Примечание = Прием.Примечание

                                                 }
                                                 select p).ToList();

                return View("ReceptPage", model);
            }
        }
        public ActionResult ReceptSearch(string dateSearch, string surnameSearch)
        {

            
               
            
            using (ClinicEntities entities = new ClinicEntities())
            {
                if ((dateSearch == "") && (surnameSearch != ""))
                {
                    List<ReceptionAtDoctor> model = (from Прием in entities.Прием
                                                     join Пациенты in entities.Пациенты on Прием.ID_пациента equals Пациенты.ID_пациента
                                                     join Врачи in entities.Врачи on Прием.ID_врача equals Врачи.ID_врача
                                                     join Сотрудники in entities.Сотрудники on Врачи.ID_сотрудника equals Сотрудники.ID_сотрудника
                                                     join Специальности in entities.Специальности on Врачи.Код_специальности equals Специальности.Код_специальности
                                                     where Сотрудники.Фамилия.Contains(surnameSearch)
                                                     let p = new ReceptionAtDoctor
                                                     {
                                                         ID_приема = Прием.ID_приема,
                                                         ID_врача = Прием.ID_врача,
                                                         ID_пациента = Прием.ID_пациента,
                                                         ф_врача = Сотрудники.Фамилия,
                                                         и_врача = Сотрудники.Имя,
                                                         о_врача = Сотрудники.Отчество,
                                                         ф_пациента = Пациенты.Фамилия,
                                                         и_пациента = Пациенты.Имя,
                                                         о_пациента = Пациенты.Отчество,
                                                         Дата_приема = Прием.Дата,
                                                         Диагноз = Прием.Диагноз,
                                                         Рецепт = Прием.Рецепт,
                                                         Специальность = Специальности.Наименование,
                                                         Примечание = Прием.Примечание


                                                     }
                                                     select p).ToList();
                    return PartialView(model);
                }
                else if ((dateSearch != "") && (surnameSearch == ""))
                {
                    DateTime date = Convert.ToDateTime(dateSearch);
                    List<ReceptionAtDoctor> model = (from Прием in entities.Прием
                                                     join Пациенты in entities.Пациенты on Прием.ID_пациента equals Пациенты.ID_пациента
                                                     join Врачи in entities.Врачи on Прием.ID_врача equals Врачи.ID_врача
                                                     join Сотрудники in entities.Сотрудники on Врачи.ID_сотрудника equals Сотрудники.ID_сотрудника
                                                     join Специальности in entities.Специальности on Врачи.Код_специальности equals Специальности.Код_специальности
                                                     where Прием.Дата==date
                                                     let p = new ReceptionAtDoctor
                                                     {
                                                         ID_приема = Прием.ID_приема,
                                                         ID_врача = Прием.ID_врача,
                                                         ID_пациента = Прием.ID_пациента,
                                                         ф_врача = Сотрудники.Фамилия,
                                                         и_врача = Сотрудники.Имя,
                                                         о_врача = Сотрудники.Отчество,
                                                         ф_пациента = Пациенты.Фамилия,
                                                         и_пациента = Пациенты.Имя,
                                                         о_пациента = Пациенты.Отчество,
                                                         Дата_приема = Прием.Дата,
                                                         Диагноз = Прием.Диагноз,
                                                         Рецепт = Прием.Рецепт,
                                                         Специальность = Специальности.Наименование,
                                                         Примечание = Прием.Примечание


                                                     }
                                                     select p).ToList();
                    return PartialView(model);
                }
                else if ((dateSearch != "") && (surnameSearch != ""))
                {
                    DateTime date = Convert.ToDateTime(dateSearch);
                    List<ReceptionAtDoctor> model = (from Прием in entities.Прием
                                                     join Пациенты in entities.Пациенты on Прием.ID_пациента equals Пациенты.ID_пациента
                                                     join Врачи in entities.Врачи on Прием.ID_врача equals Врачи.ID_врача
                                                     join Сотрудники in entities.Сотрудники on Врачи.ID_сотрудника equals Сотрудники.ID_сотрудника
                                                     join Специальности in entities.Специальности on Врачи.Код_специальности equals Специальности.Код_специальности
                                                     where Прием.Дата==date && Сотрудники.Фамилия.Contains(surnameSearch)
                                                     let p = new ReceptionAtDoctor
                                                     {
                                                         ID_приема = Прием.ID_приема,
                                                         ID_врача = Прием.ID_врача,
                                                         ID_пациента = Прием.ID_пациента,
                                                         ф_врача = Сотрудники.Фамилия,
                                                         и_врача = Сотрудники.Имя,
                                                         о_врача = Сотрудники.Отчество,
                                                         ф_пациента = Пациенты.Фамилия,
                                                         и_пациента = Пациенты.Имя,
                                                         о_пациента = Пациенты.Отчество,
                                                         Дата_приема = Прием.Дата,
                                                         Диагноз = Прием.Диагноз,
                                                         Рецепт = Прием.Рецепт,
                                                         Специальность = Специальности.Наименование,
                                                         Примечание = Прием.Примечание


                                                     }
                                                     select p).ToList();
                    return PartialView(model);



                }







                else
                {
                    List<ReceptionAtDoctor> model = (from Прием in entities.Прием
                                                     join Пациенты in entities.Пациенты on Прием.ID_пациента equals Пациенты.ID_пациента
                                                     join Врачи in entities.Врачи on Прием.ID_врача equals Врачи.ID_врача
                                                     join Сотрудники in entities.Сотрудники on Врачи.ID_сотрудника equals Сотрудники.ID_сотрудника
                                                     let p = new ReceptionAtDoctor
                                                     {
                                                         ID_приема = Прием.ID_приема,
                                                         ID_врача = Прием.ID_врача,
                                                         ID_пациента = Прием.ID_пациента,
                                                         ф_врача = Сотрудники.Фамилия,
                                                         и_врача = Сотрудники.Имя,
                                                         о_врача = Сотрудники.Отчество,
                                                         ф_пациента = Пациенты.Фамилия,
                                                         и_пациента = Пациенты.Имя,
                                                         о_пациента = Пациенты.Отчество,
                                                         Дата_приема = Прием.Дата,
                                                         Диагноз = Прием.Диагноз,
                                                         Рецепт = Прием.Рецепт,
                                                         Примечание = Прием.Примечание

                                                     }
                                                     select p).ToList();
                    return PartialView(model);
                }
            }
        }

        [HttpPost]
        public ActionResult RegistrationOnly(Пациенты model)
        {
            if ((Request.IsAuthenticated) &&
                (System.Web.HttpContext.Current.User.IsInRole("регистратура") || System.Web.HttpContext.Current.User.IsInRole("админ")))
            {
                if (ModelState.IsValid)
                {
                    using (ClinicEntities entities = new ClinicEntities())
                    {
                        entities.Пациенты.Add(model);
                        model.ID_пациента = Guid.NewGuid();
                        entities.SaveChanges();
                        return RedirectToAction("PatientDatabase", "Account", new { flag = true });
                    }
                }
                else return View();
            }
            else
                return RedirectToAction("Index", "Home");
        }


        public ActionResult PatientDatabase(bool flag = false)
        {
            ViewBag.Flag = flag;
            if ((Request.IsAuthenticated) &&
                (System.Web.HttpContext.Current.User.IsInRole("регистратура") || System.Web.HttpContext.Current.User.IsInRole("админ")))
            {

                using (ClinicEntities entities = new ClinicEntities())
                {
                    List<Пациенты> model = entities.Пациенты.Include("Адреса").ToList();
                    if (Request.IsAjaxRequest()) return PartialView(model);
                    else return View(model);
                }
            }
            else
                return RedirectToAction("Index", "Home");
        }


        public ActionResult SheduleOnly()
        {
            if ((Request.IsAuthenticated) &&
                (System.Web.HttpContext.Current.User.IsInRole("расписание") || System.Web.HttpContext.Current.User.IsInRole("админ")))
            {
                if (Request.IsAjaxRequest()) return PartialView();
                else return View();
            }
            else
                return RedirectToAction("Index", "Home");
        }


    }
}
