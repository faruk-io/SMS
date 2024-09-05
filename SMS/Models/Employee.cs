using System.ComponentModel.DataAnnotations;

namespace SMS.Models
{
    public class Employee
    {
        [Key]
        public int emp_id { get; set; }
        public string emp_name { get; set; }
    }
}
