using System.ComponentModel.DataAnnotations;

namespace SMS.Models
{
    public class Delivery
    {
        [Key]
        public int delivery_id { get; set; }
        public DateTime delivery_date { get; set; }
        public string emp_name { get; set; }
        public int qnty { get; set; }
    }
}
