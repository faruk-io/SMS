using System.ComponentModel.DataAnnotations;

namespace SMS.Models
{
    public class Vendor
    {
        [Key]
        public int vendor_id { get; set; }
        public string vendor_name { get; set; }

    }
}
