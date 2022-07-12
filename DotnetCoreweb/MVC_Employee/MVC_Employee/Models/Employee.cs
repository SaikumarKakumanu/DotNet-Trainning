using System.ComponentModel.DataAnnotations;

namespace MVC_Employee.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Enter First Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; }= string.Empty;
    }
}
