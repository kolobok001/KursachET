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
    
    public partial class Процедуры
    {
        public Процедуры()
        {
            this.Прием = new HashSet<Прием>();
        }
    
        public int Код_процедуры { get; set; }
        public string Наименование { get; set; }
        public int Код_специальности { get; set; }
    
        public virtual Специальности Специальности { get; set; }
        public virtual ICollection<Прием> Прием { get; set; }
    }
}
