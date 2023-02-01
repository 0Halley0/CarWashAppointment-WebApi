using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    internal interface IAppointmentDal
    {
        List<Appointment> GetAllAppointments();
        void AddAppointment(Appointment appointment);
        void DeleteAppointment(Appointment appointment);
        void UpdateAppointment(Appointment appointment);
        Appointment GetAppointmentById(int id);
    }
}
