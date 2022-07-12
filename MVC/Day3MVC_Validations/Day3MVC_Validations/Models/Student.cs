using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day3MVC_Validations.Models
{
    public class Student
    {
        [Display(Name="Student Roll No :")]
        public int RollNo { get; set; }
        [Display(Name="Student Name :")]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
    }
}