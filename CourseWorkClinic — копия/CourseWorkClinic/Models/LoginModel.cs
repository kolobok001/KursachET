using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseWorkClinic.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Имя пользователя")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

    }

    //public class Patient
    //{
    //    [Required]
    //    [Display(Name = "№ полиса")]
    //    public string PoliceNumber { get; set; }

    //    [Required]
    //    [Display(Name = "Фамилия")]
    //    public string Surname { get; set; }

    //    [Required]
    //    [Display(Name = "Имя")]
    //    public string Surname { get; set; }

    //    [Required]
    //    [Display(Name = "Отчество")]
    //    public string Surname { get; set; }

    //    [Required]
    //    [Display(Name = "Фамилия")]
    //    public string Surname { get; set; }
    //}
}