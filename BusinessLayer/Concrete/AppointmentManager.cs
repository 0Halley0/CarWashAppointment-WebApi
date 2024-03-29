﻿using BusinessLayer.Abstract;
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
		private readonly IAppointmentDal _appointmentDal;

		public AppointmentManager(IAppointmentDal appointmentDal)
		{
			_appointmentDal = appointmentDal;
		}

		public List<Appointment> GetListByAppointmentDate()
		{
			return _appointmentDal.GetListByAppointmentDate();
		}

		public List<Appointment> GetListByCategory()
		{
			return _appointmentDal.GetListByCategory();
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
