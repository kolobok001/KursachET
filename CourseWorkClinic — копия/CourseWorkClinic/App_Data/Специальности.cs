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
    
    public partial class Специальности
    {
        public Специальности()
        {
            this.Врачи = new HashSet<Врачи>();
            this.Процедуры = new HashSet<Процедуры>();
        }
    
        public int Код_специальности { get; set; }
        public string Наименование { get; set; }
    
        public virtual ICollection<Врачи> Врачи { get; set; }
        public virtual ICollection<Процедуры> Процедуры { get; set; }
    }
}
