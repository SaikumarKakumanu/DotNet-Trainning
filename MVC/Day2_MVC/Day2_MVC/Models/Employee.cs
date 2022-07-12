using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day2_MVC.Models
{
    public class Employee
    {
        [Display(Name="Employee Id :")]
        public int Id { get; set; }
        [Display(Name = "Employee Name :")]
        public string Name { get; set; }

        [Display(Name = "Date Of Joining :")]
        public Nullable<System.DateTime> DOJ { get; set; }

        [Display(Name = "Employee Email :")]
        public string Email { get; set; }
    }
}