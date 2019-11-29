using Domain;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace UsingEF
{

    public class EFStaffRepository
    {
        //класс для доступа к компоненту DbContext
        private EFDbContext context;

        public EFStaffRepository()
        {
            //инициализация поля
            context = new EFDbContext(ConfigurationManager.ConnectionStrings[0].ConnectionString);
        }

        //определим методы для манипуляции с сотрудниками

        public IEnumerable<Сотрудники> GetStaff() //выбрать все записи из таблицы сотрудники в БД
        {
            return (IEnumerable<Сотрудники>)context.Staff;
        }

       // public IEnumerable<Book> GetBooks() //выбрать все записи из таблицы сотрудники в БД
       // {
       //     return (IEnumerable<Book>)context.Books;
      //  }
    }
}