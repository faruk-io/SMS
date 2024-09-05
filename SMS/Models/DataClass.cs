using SMS.Data;
using System.ComponentModel.DataAnnotations;

namespace SMS.Models
{
    public class DataClass
    {
        [Key]

        private readonly ApplicationDbContext applicationDbContext;
        public DataClass(ApplicationDbContext cc)
        {
            applicationDbContext = cc;
        }

        public IList<Item> items;
        public IList<Service> services;
        public IList<Delivery> deliveries;

        public IList<Item> getitemdata(String Data)
        {
            if (Data == null)
            {
                items = applicationDbContext.items.ToList();

            }
            items = applicationDbContext.items.Where(x => x.item_status == Data).ToList();
            return items;
        }

        public IList<Service> getservicedata(String Data)
        {
            if (Data == null)
            {
                services = applicationDbContext.services.ToList();

            }
            services = applicationDbContext.services.Where(x => x.vendor_name == Data).ToList();
            return services;
        }

        public IList<Delivery> getdelivarydata(String Data)
        {
            if (Data == null)
            {
                deliveries = applicationDbContext.deliveries.ToList();

            }
            deliveries = applicationDbContext.deliveries.Where(x => x.emp_name == Data).ToList();
            return deliveries;
        }

    }
}
