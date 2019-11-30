using CourseWorkClinic.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace CourseWorkClinic.Models
{
    public static class Helper
    {
        public static MvcHtmlString PagingNavigator(this AjaxHelper helper)
        {
            StringBuilder sb = new StringBuilder();
            AjaxOptions ao = new AjaxOptions();

            ao.UpdateTargetId = "AjaxDiv";

            sb.Append(helper.ActionLink("Главная", "Index", new {pageName = "Главная"}, ao));
            sb.Append(helper.ActionLink("Для льготников", "Index", new {pageName = "Для льготников"},ao));
            sb.Append(helper.ActionLink("Контакты", "Index", new {pageName = "Контакты"},ao));
            sb.Append(helper.ActionLink("Расписание врачей", "Index", new {pageName = "Расписание врачей"},ao));
            sb.Append(helper.ActionLink("Участки", "Index", new { pageName = "Участки" }, ao));

            return MvcHtmlString.Create(sb.ToString());
        }

        public static string GetAdress(Адреса item )
        {
            string s = item.Улица + " " + item.Дом.ToString();
            return s;
        }
        public static string GetFioPacient(Пациенты item)
        {
            string s = item.Фамилия + " " + item.Отчество+" "+ item.Отчество;
            return s;
        }
        public static string GetFioDoctor(CourseWorkClinic.Models.DoctorList item)
        {
            string s = item.Фамилия + " " + item.Отчество + " " + item.Отчество;
            return s;
        }
    }
}