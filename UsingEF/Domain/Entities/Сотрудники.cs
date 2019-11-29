using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }

    public class Сотрудники
    {
        [Key, Column("ID сотрудника")] //можно указать тип конкретный
        public Guid staffID { get; set; }
        [Column("Фамилия")]
        public string Surname { get; set; } //фамилия
        [Column("Имя")]
        public string Firstname { get; set; } //имя
        [Column("Отчество")]
        public string Patronymic { get; set; } //Отчество 
    }

    public class Врачи
    {
        [Key, Column("ID врача")] //можно указать тип конкретный
        public Guid Id { get; set; }
        [Column("Код специальности")]
        public int WorkCod { get; set; }
        [Column("ID сотрудника")]
        public Guid StaffId { get; set; }
    }

    public class Специальности
    {
        [Key, Column("ID Сотрудника")] //можно указать тип конкретный
        public int specId { get; set; }
        public string Name { get; set; }
    }

    public class Расписание
    {
        [Key, Column("ID Сотрудника")] //можно указать тип конкретный
        public Guid Id { get; set; }
        public string Week { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int KabNumber { get; set; }
        public Guid DoctorID { get; set; }
        public int DayCod { get; set; }
    }

    public class ДниНедели
    {
        [Key, Column("ID Сотрудника")] //можно указать тип конкретный
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Участки
    {
        [Key, Column("ID Сотрудника")] //можно указать тип конкретный
        public int Id { get; set; }
        public Guid DoctorID { get; set; }
    }

    public class АдресаВУчастках
    {
        [Key, Column("ID Сотрудника")] //можно указать тип конкретный
        public int Id { get; set; }
        public int adressID { get; set; }
    }

    public class Адреса
    {
        [Key, Column("ID Сотрудника")] //можно указать тип конкретный
        public int adressID { get; set; }
        public string Street { get; set; }
        public float homeNumber { get; set; }
    }

    public class Пациенты
    {
        [Key, Column("ID Сотрудника")] //можно указать тип конкретный
        public Guid ID { get; set; }
        public string NumberPolice { get; set; }
        public string Surname { get; set; } //фамилия
        public string Firstname { get; set; } //имя
        public string Patronymic { get; set; } //Отчество
        public string DateBirth { get; set; }
        public string DateDeath { get; set; }
        public int AdressID { get; set; }
    }

    public class Прием
    {
        [Key, Column("ID Сотрудника")] //можно указать тип конкретный
        public Guid visitID { get; set; }
        public string Date { get; set; }
        public float ProcessTime { get; set; } //фамилия
        public string Diagnoz { get; set; } //имя
        public string Recept { get; set; } //Отчество
        public string Definition { get; set; }
        public Guid NumberDirections { get; set; } //номер направления
        public Guid DoctorID { get; set; }
        public Guid PatientId { get; set; }
    }

    public class Процедуры
    {
        [Key, Column("ID Сотрудника")] //можно указать тип конкретный
        public int procedureID { get; set; }
        public string Name { get; set; }
        public int specId { get; set; }
    }

    public class ПроцедурыВПриеме
    {
        [Key, Column("ID Сотрудника")] //можно указать тип конкретный
        public int procedureID { get; set; }
        public Guid visitID { get; set; }
    }

    public class Направление
    {
        [Key, Column("ID Сотрудника")] //можно указать тип конкретный
        public Guid NumberDirections { get; set; }
        public Guid DoctorID { get; set; }
        public Guid GetDoctorID { get; set; }
        public Guid PatientId { get; set; }
    }

    //public class Сотрудники
    //{
    //    public string Id { get; set; }
    //    public string Surname { get; set; } //фамилия
    //    public string Firstname { get; set; } //имя
    //    public string Patronymic { get; set; } //Отчество 
    //}

    //public class Врачи
    //{
    //    public string Id { get; set; }
    //    public int WorkCod { get; set; } 
    //    public string StaffId { get; set; } 
    //}

    //public class Специальности
    //{
    //    public int specId { get; set; }
    //    public string Name { get; set; }
    //}

    //public class Расписание
    //{
    //    public string Id { get; set; }
    //    public string Week { get; set; }
    //    public string StartTime { get; set; }
    //    public string EndTime { get; set; }
    //    public int KabNumber { get; set; }
    //    public string DoctorID { get; set; }
    //    public int DayCod { get; set; }
    //}

    //public class ДниНедели
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    //public class Участки
    //{
    //    public int Id { get; set; }
    //    public string DoctorID { get; set; }
    //}

    //public class АдресаВУчастках
    //{
    //    public int Id { get; set; }
    //    public int adressID { get; set; }
    //}

    //public class Адреса
    //{
    //    public int adressID { get; set; }
    //    public string Street { get; set; }
    //    public float homeNumber { get; set; }
    //}

    //public class Пациенты
    //{
    //    public string ID { get; set; }
    //    public string NumberPolice { get; set; }
    //    public string Surname { get; set; } //фамилия
    //    public string Firstname { get; set; } //имя
    //    public string Patronymic { get; set; } //Отчество
    //    public string DateBirth { get; set; }
    //    public string DateDeath { get; set; }
    //    public int    AdressID { get; set; }
    //}

    //public class Прием
    //{
    //    public string visitID { get; set; }
    //    public string Date { get; set; }
    //    public float  ProcessTime { get; set; } //фамилия
    //    public string Diagnoz { get; set; } //имя
    //    public string Recept { get; set; } //Отчество
    //    public string Definition { get; set; }
    //    public string NumberDirections { get; set; } //номер направления
    //    public string DoctorID { get; set; }
    //    public string PatientId { get; set; }
    //}

    //public class Процедуры
    //{
    //    public int procedureID { get; set; }
    //    public string Name { get; set; }
    //    public int specId { get; set; }
    //}

    //public class ПроцедурыВПриеме
    //{
    //    public int procedureID { get; set; }
    //    public string visitID { get; set; }
    //}

    //public class Направление
    //{
    //    public string NumberDirections { get; set; }
    //    public string DoctorID { get; set; }
    //    public string GetDoctorID { get; set; }
    //    public string PatientId { get; set; }
    //}
}
