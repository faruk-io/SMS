using System.ComponentModel.DataAnnotations;

namespace SMS.Models
{
    public class Service
    {
        [Key]
        public int service_id { get; set; }
        public int service_Po_no { get; set; }
        public string service_item { get; set; }
        public int service_qnty { get; set; }
        public DateTime service_date { get; set; }
        public int costing_price { get; set; }
        public string vendor_name { get; set; }
        public string description { get; set; }
    }
}
