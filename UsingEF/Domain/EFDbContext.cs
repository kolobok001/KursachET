using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(string connectionString) //строка будет приходить из WebConfig
        {
            Database.Connection.ConnectionString = connectionString;
        }

        //определим коллекцию данных для классов из базы
        public DbSet<Сотрудники> Staff { get; set;}
        //public DbSet<Book> Books { get; set; }
    }
}
