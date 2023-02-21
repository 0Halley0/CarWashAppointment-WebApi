using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=CarWashAppointmentDb;integrated security=true;");
        }
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options) { }   
        public DbSet<About> Abouts { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<CarWash> CarWashes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<AppointmentList> AppointmentList { get; set; }
    }
}
