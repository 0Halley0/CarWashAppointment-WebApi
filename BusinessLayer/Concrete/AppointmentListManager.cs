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
	public class AppointmentListManager:IAppointmentListService
	{
		private readonly IAppointmentListDal _appointmentListDal;

		public AppointmentListManager(IAppointmentListDal appointmentListDal)
		{
			_appointmentListDal = appointmentListDal;
		}
		public void TAdd(AppointmentList t)
		{
			_appointmentListDal.Insert(t);
		}

		public void TDelete(AppointmentList t)
		{
			_appointmentListDal.Delete(t);
		}

		public List<AppointmentList> TGetAll()
		{
			return _appointmentListDal.GetAll();
		}

		public AppointmentList TGetById(int id)
		{
			return _appointmentListDal.GetById(id);
		}

		public void TUpdate(AppointmentList t)
		{
			_appointmentListDal.Update(t);
		}
	}

}
