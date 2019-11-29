using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ajax_Learning.Models
{
    public class Person
    {
        public string Name { get; set; }
        public PersonType Type { get; set; }
    }

    public enum PersonType
    {
        Student, Worker
    }
}