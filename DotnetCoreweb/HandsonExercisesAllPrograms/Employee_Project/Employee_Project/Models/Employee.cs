using System.ComponentModel.DataAnnotations;

namespace Employee_Project.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Enter First Name")]
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
