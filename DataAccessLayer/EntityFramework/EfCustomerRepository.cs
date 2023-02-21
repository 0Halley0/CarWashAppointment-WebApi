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
	public class EfCustomerRepository : GenericRepository<Customer>, ICustomerDal
	{
		public Customer GetByEmail(string email)
		{
			using (var context = new Context())
			{
				var values = context.Customers.Where(x => x.Email == email);
				return (Customer)values;
			}
		}

		public Customer GetByPlateNumber(string plateNumber)
		{
			throw new NotImplementedException();
		}
	}
}
