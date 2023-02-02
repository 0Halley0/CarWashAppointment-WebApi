using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfAppointmentRepository : GenericRepository<Appointment>, IAppointmentDal
	{
		public List<Appointment> GetListWithCategory()
		{
			using(var c=new Context())
			{
				return c.Appointments.Include(x=>x.Category).ToList();
			}
		}
	}
}
