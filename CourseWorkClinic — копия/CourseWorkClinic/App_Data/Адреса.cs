//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseWorkClinic.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Адреса
    {
        public Адреса()
        {
            this.Пациенты = new HashSet<Пациенты>();
            this.Участки = new HashSet<Участки>();
        }
    
        public int Код_адреса { get; set; }
        public string Улица { get; set; }
        public double Дом { get; set; }
    
        public virtual ICollection<Пациенты> Пациенты { get; set; }
        public virtual ICollection<Участки> Участки { get; set; }
    }
}
