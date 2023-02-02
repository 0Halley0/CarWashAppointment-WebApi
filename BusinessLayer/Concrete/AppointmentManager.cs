using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class AppointmentManager : IAppointmentService
	{
		IAppointmentDal _appointmentDal;

		public AppointmentManager(IAppointmentDal appointmentDal)
		{
			_appointmentDal = appointmentDal;
		}

		public List<Appointment> GetListWithCategory()
		{
			return _appointmentDal.GetListWithCategory();
		}

		public void TAdd(Appointment t)
		{
			_appointmentDal.Insert(t);
		}

		public void TDelete(Appointment t)
		{
			_appointmentDal.Delete(t);
		}

		public List<Appointment> TGetAll()
		{
			return _appointmentDal.GetAll();
		}

		public Appointment TGetById(int id)
		{
			return _appointmentDal.GetById(id);
		}

		public void TUpdate(Appointment t)
		{
			_appointmentDal.Update(t);
		}
	}
}
