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
    
    public partial class Участки
    {
        public Участки()
        {
            this.Адреса = new HashSet<Адреса>();
        }
    
        public int C_участка { get; set; }
        public System.Guid ID_врача { get; set; }
    
        public virtual Врачи Врачи { get; set; }
        public virtual ICollection<Адреса> Адреса { get; set; }
    }
}
