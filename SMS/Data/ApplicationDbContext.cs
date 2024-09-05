using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMS.Models;

namespace SMS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Item> items { get; set; }
        public DbSet<Delivery> deliveries { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Vendor> vendors { get; set; }
        public DbSet<Employee> employees { get; set; }
        //public object Service { get; internal set; }
        //public DbSet<IdentityUser> identityUser { get; set; }

    }
}

