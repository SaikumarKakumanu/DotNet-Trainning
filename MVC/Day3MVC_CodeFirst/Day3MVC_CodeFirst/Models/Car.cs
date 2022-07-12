using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Day3MVC_CodeFirst.Models
{
    [Table("TblCar")]
    public class Car
    {
        [Key]
        public int CarNo { get; set; }
        public string CarName { get; set; }
        public string CarType { get; set; }
        public double CarCost { get; set; }
    }
}