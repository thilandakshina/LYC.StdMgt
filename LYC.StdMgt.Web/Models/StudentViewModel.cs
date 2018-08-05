using LYC.StdMgt.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYC.StdMgt.Web.Models
{
    public class StudentViewModel
    {
        //public string Code { get; set; }
        public string ParentName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
    }
}