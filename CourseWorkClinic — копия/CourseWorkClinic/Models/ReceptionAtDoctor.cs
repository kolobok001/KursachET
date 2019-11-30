using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseWorkClinic.Models
{
    public class ReceptionAtDoctor
    {
        public System.Guid ID_приема { get; set; }
        public System.Guid ID_врача { get; set; }
        public System.Guid ID_пациента { get; set; }
        public string ф_врача { get; set; }
        public string Специальность { get; set; }
        public string и_врача { get; set; }
        public string о_врача { get; set; }
        public string ф_пациента  { get; set; }
        public string и_пациента { get; set; }
        public string о_пациента { get; set; }
        public System.DateTime Дата_приема { get; set; }

        public string Диагноз { get; set; }
        public string Рецепт { get; set; }
        public string Примечание { get; set; }
        
     
    }
}