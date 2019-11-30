using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseWorkClinic.Models
{
    public class DoctorList
    {
        
            public string Специальность { get; set; }
            public int Код_специальности { get; set; }
            public string Фамилия { get; set; }
            public string Имя { get; set; }
            public string Отчество { get; set; }
            public System.Guid Id_врача { get; set; }
        
    }

}
