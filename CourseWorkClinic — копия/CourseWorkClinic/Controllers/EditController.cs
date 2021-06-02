using CourseWorkClinic.App_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseWorkClinic.Controllers
{
    public class EditController : Controller
    {


        public ActionResult DeleteShedule()
        {
            using (ClinicEntities entities = new ClinicEntities())
            {
                Guid dId = Guid.Parse(Request["DoctorId"]);
                var week = Request["Week"];
                List<Расписание> myEntities = new List<Расписание>();
                myEntities = entities.Расписание.Where(x => x.ID_врача == dId && x.Неделя == week).ToList();

                foreach (var item in myEntities)
                {
                    entities.Расписание.Remove(item);
                }

                entities.SaveChanges();
            }
            return View();
        }

        public ActionResult EditSh()
        {
            using (ClinicEntities entities = new ClinicEntities())
            {
                Guid dId = Guid.Parse(Request["DoctorId"]);
                var week = Request["Week"];

                var mondayS = Request["MondayS"];
                var mondayF = Request["MondayF"];
                var mondayKab = Request["MondayKab"];

                var tuesdayS = Request["TuesdayS"];
                var tuesdayF = Request["TuesdayF"];
                var tuesdayKab = Request["TuesdayKab"];

                var wednesdayS = Request["WednesdayS"];
                var wednesdayF = Request["WednesdayF"];
                var wednesdayKab = Request["WednesdayKab"];

                var thursdayS = Request["ThursdayS"];
                var thursdayF = Request["ThursdayF"];
                var thursdayKab = Request["ThursdayKab"];

                var fridayS = Request["FridayS"];
                var fridayF = Request["FridayF"];
                var fridayKab = Request["FridayKab"];

                var saturdayS = Request["SaturdayS"];
                var saturdayF = Request["SaturdayF"];
                var saturdayKab = Request["SaturdayKab"];

                List<Расписание> myEntities = new List<Расписание>();
                myEntities = entities.Расписание.Where(x => x.ID_врача == dId && x.Неделя == week).ToList();

                if ((mondayS != "не работает") && (mondayS != ""))
                {
                    Расписание понедельник = null;

                    try { понедельник = myEntities.Where(x => x.Код_дня == 1).First(); }
                    catch (Exception ex) { }

                    if (понедельник == null)
                    {
                        понедельник = new Расписание();
                        понедельник.ID_записи = Guid.NewGuid();
                        понедельник.ID_врача = dId;
                        понедельник.Код_дня = 1;
                        понедельник.Неделя = week;
                        entities.Расписание.Add(понедельник);
                    }
                    else entities.Entry(понедельник).State = EntityState.Modified;

                    понедельник.Время_начала = TimeSpan.Parse(mondayS);
                    понедельник.Время_окончания = TimeSpan.Parse(mondayF);
                    понедельник.C__кабинета = Convert.ToInt32(mondayKab);
                }

                if ((tuesdayS != "не работает") && (tuesdayS != ""))
                {
                    Расписание вторник = null;

                    try { вторник = myEntities.Where(x => x.Код_дня == 2).First(); }
                    catch (Exception ex) { }

                    if (вторник == null)
                    {
                        вторник = new Расписание();
                        вторник.ID_записи = Guid.NewGuid();
                        вторник.ID_врача = dId;
                        вторник.Код_дня = 2;
                        вторник.Неделя = week;
                        entities.Расписание.Add(вторник);
                    }
                    else entities.Entry(вторник).State = EntityState.Modified;

                    вторник.Время_начала = TimeSpan.Parse(tuesdayS);
                    вторник.Время_окончания = TimeSpan.Parse(tuesdayF);
                    вторник.C__кабинета = Convert.ToInt32(tuesdayKab);
                }

                if ((wednesdayS != "не работает") && (wednesdayS != ""))
                {
                    Расписание среда = null;

                    try { среда = myEntities.Where(x => x.Код_дня == 3).First(); }
                    catch (Exception ex) { }

                    if (среда == null)
                    {
                        среда = new Расписание();
                        среда.ID_записи = Guid.NewGuid();
                        среда.ID_врача = dId;
                        среда.Код_дня = 3;
                        среда.Неделя = week;
                        entities.Расписание.Add(среда);
                    }
                    else entities.Entry(среда).State = EntityState.Modified;

                    среда.Время_начала = TimeSpan.Parse(wednesdayS);
                    среда.Время_окончания = TimeSpan.Parse(wednesdayF);
                    среда.C__кабинета = Convert.ToInt32(wednesdayKab);
                }

                if ((thursdayS != "не работает") && (thursdayS != ""))
                {
                    Расписание четверг = null;

                    try { четверг = myEntities.Where(x => x.Код_дня == 4).First(); }
                    catch (Exception ex) { }

                    if (четверг == null)
                    {
                        четверг = new Расписание();
                        четверг.ID_записи = Guid.NewGuid();
                        четверг.ID_врача = dId;
                        четверг.Код_дня = 4;
                        четверг.Неделя = week;
                        entities.Расписание.Add(четверг);
                    }
                    else entities.Entry(четверг).State = EntityState.Modified;

                    четверг.Время_начала = TimeSpan.Parse(thursdayS);
                    четверг.Время_окончания = TimeSpan.Parse(thursdayF);
                    четверг.C__кабинета = Convert.ToInt32(thursdayKab);
                }

                if ((fridayS != "не работает") && (fridayS != ""))
                {
                    Расписание пятница = null;

                    try { пятница = myEntities.Where(x => x.Код_дня == 5).First(); }
                    catch (Exception ex) { }

                    if (пятница == null)
                    {
                        пятница = new Расписание();
                        пятница.ID_записи = Guid.NewGuid();
                        пятница.ID_врача = dId;
                        пятница.Код_дня = 5;
                        пятница.Неделя = week;
                        entities.Расписание.Add(пятница);
                    }
                    else entities.Entry(пятница).State = EntityState.Modified;

                    пятница.Время_начала = TimeSpan.Parse(fridayS);
                    пятница.Время_окончания = TimeSpan.Parse(fridayF);
                    пятница.C__кабинета = Convert.ToInt32(fridayKab);
                }

                if ((saturdayS != "не работает") && (saturdayS != ""))
                {
                    Расписание суббота = null;

                    try { суббота = myEntities.Where(x => x.Код_дня == 6).First(); }
                    catch (Exception ex) { }

                    if (суббота == null)
                    {
                        суббота = new Расписание();
                        суббота.ID_записи = Guid.NewGuid();
                        суббота.ID_врача = dId;
                        суббота.Код_дня = 6;
                        суббота.Неделя = week;
                        entities.Расписание.Add(суббота);
                    }
                    else entities.Entry(суббота).State = EntityState.Modified;

                    суббота.Время_начала = TimeSpan.Parse(saturdayS);
                    суббота.Время_окончания = TimeSpan.Parse(saturdayF);
                    суббота.C__кабинета = Convert.ToInt32(saturdayKab);
                }
                entities.SaveChanges();
            }
            return View();
        }

        public ActionResult DeletePatient()
        {
            return View();
        }
        public ActionResult DeleteRecept()
        {
            return View();
        }
        public ActionResult EditShedule()
        {
            return View();
        }

        public ActionResult EditRecept(Guid id)
        {
            using (ClinicEntities entities = new ClinicEntities())
            {
                Прием model = entities.Прием.Where(a => a.ID_приема == id).First();
                return View(model);
            }


        }
        [HttpPost]
        public ActionResult EditRecept(Прием myP)

        {
            using (ClinicEntities entities = new ClinicEntities())
            {
                entities.Entry(myP).State = EntityState.Modified;
                entities.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
        }



        public ActionResult EditPatient()
        {
            using (ClinicEntities entities = new ClinicEntities())
            {

                Guid pId = Guid.Parse(Request["PatientId"]);
                //Пациенты myP = entities.Пациенты.Where(x => x.ID_пациента == pId).First();
                Пациенты myP = entities.Пациенты.Find(pId);

                myP.C__полиса = Request["Police"];
                myP.Фамилия = Request["Surname"];
                myP.Имя = Request["Firstname"];
                myP.Отчество = Request["Patronomic"];

                myP.Дата_рождения = Convert.ToDateTime(Request["BirthDate"]);

                var deathDate = Request["DeathDate"];
                if (deathDate == "")
                {
                    myP.Дата_смерти = null;
                }
                else myP.Дата_смерти = Convert.ToDateTime(Request["DeathDate"]);

                myP.Код_адреса = Convert.ToInt32(Request["AdressList"]);

                entities.Entry(myP).State = EntityState.Modified;
                entities.SaveChanges();
            }
            return View();
        }

        /*Управление сотрудниками*/
        public ActionResult DeleteStaff()
        {
            using (ClinicEntities entities = new ClinicEntities())
            {
                Guid pId = Guid.Parse(Request["StaffId"]);
                Сотрудники myP = entities.Сотрудники.Find(pId);

                entities.Сотрудники.Remove(myP);
                entities.SaveChanges();

                //string expression = "DELETE FROM Пациенты WHERE [ID пациента] = '" + patientId + "'";
                //entities.Database.ExecuteSqlCommand(expression);
            }

            return View();
        }

        public ActionResult EditStaff()
        {
            using (ClinicEntities entities = new ClinicEntities())
            {

                Guid pId = Guid.Parse(Request["StaffId"]);
                Сотрудники myP = entities.Сотрудники.Find(pId);

                myP.Фамилия = Request["Surname"];
                myP.Имя = Request["Firstname"];
                myP.Отчество = Request["Patronymic"];

                entities.Entry(myP).State = EntityState.Modified;
                entities.SaveChanges();
            }
            return View();
        }

        public ActionResult AddStaff()
        {
            using (ClinicEntities entities = new ClinicEntities())
            {
                Врачи newVrach = new Врачи();
                Сотрудники newStaff = new Сотрудники();
                newStaff.ID_сотрудника = Guid.NewGuid();
                newVrach.ID_врача = Guid.NewGuid();
                newVrach.ID_сотрудника = newStaff.ID_сотрудника;
                newStaff.Фамилия = Request["Surname"];
                newStaff.Имя = Request["Firstname"];
                newStaff.Отчество = Request["Patronymic"];


                newVrach.Код_специальности = Convert.ToInt16(Request["Speciality"]);

                entities.Сотрудники.Add(newStaff);
                entities.Врачи.Add(newVrach);
                entities.SaveChanges();
            }
            return View();
        }

        /*Управление пользователями*/
        public ActionResult DeleteUser()
        {
            using (ClinicEntities entities = new ClinicEntities())
            {
                Guid pId = Guid.Parse(Request["UserId"]);
                Пользователи myP = entities.Пользователи.Find(pId);

                entities.Пользователи.Remove(myP);
                entities.SaveChanges();

                //string expression = "DELETE FROM Пациенты WHERE [ID пациента] = '" + patientId + "'";
                //entities.Database.ExecuteSqlCommand(expression);
            }

            return View();
        }

        public ActionResult EditUser()
        {
            using (ClinicEntities entities = new ClinicEntities())
            {
                Guid pId = Guid.Parse(Request["UserId"]);
                Пользователи myP = entities.Пользователи.Find(pId);

                myP.login = Request["Login"]; ;
                myP.password = Request["Password"];
                myP.role = Request["Role"];

                entities.Entry(myP).State = EntityState.Modified;
                entities.SaveChanges();
            }
            return View();
        }
        [HttpPost]
        public ActionResult AddUser()
        {
            using (ClinicEntities entities = new ClinicEntities())
            {

                Пользователи newUser = new Пользователи();
                newUser.ID_пользователя = Guid.NewGuid();
                newUser.login = Request["Login"];
                newUser.password = Request["Password"];
                newUser.role = Request["Role"];
                newUser.Image = "default.jpg";
                entities.Пользователи.Add(newUser);
                entities.SaveChanges();

            }



            return View();
        }
        [HttpPost]
        public JsonResult Upload()
        {
            using (ClinicEntities entities = new ClinicEntities())
            {
                foreach (string file in Request.Files)
                {
                    var upload = Request.Files[file];
                    if (upload != null)
                    {
                        Guid pId = Guid.Parse(file);
                        Пользователи myP = entities.Пользователи.Find(pId);
                        // получаем имя файла
                        string fileName = Guid.NewGuid().ToString() + ".jpg";
                        // сохраняем файл в папку Files в проекте
                        upload.SaveAs(Server.MapPath("~/Files/" + fileName));
                        myP.Image = fileName;
                        entities.Entry(myP).State = EntityState.Modified;
                        entities.SaveChanges();
                    }
                }

            }
            return Json("файл загружен");
        }



    }
}
