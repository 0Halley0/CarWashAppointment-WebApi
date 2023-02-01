using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class AppointmentRepository : IAppointmentDal
    {
        public void AddAppointment(Appointment appointment)
        {
            using var c = new Context();
            c.Add(appointment);
            c.SaveChanges();
        }

        public void DeleteAppointment(Appointment appointment)
        {
            using var c = new Context();
            c.Remove(appointment);
            c.SaveChanges();
        }

        public List<Appointment> GetAllAppointments()
        {
            using var c = new Context();
            return c.Appointments.ToList();
        }

        public Appointment GetAppointmentById(int id)
        {
            using var c = new Context();
            return c.Appointments.Find(id);
        }

        public void UpdateAppointment(Appointment appointment)
        {
            using var c = new Context();
            c.Update(appointment);
            c.SaveChanges();
        }
    }
}
