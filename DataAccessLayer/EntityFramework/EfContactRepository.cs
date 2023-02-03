using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfContactRepository : GenericRepository<Contact>, IContactDal
	{
		public void ContactStatusChangeToFalse(int id)
		{
			throw new NotImplementedException();
		}

		public List<Contact> GetContactListByFalse()
		{
			using(var context=new Context())
			{
				var values=context.Contacts.Where(x=>x.ContactStatus==false).ToList();
				return values;
			}
		}

		public List<Contact> GetContactListByTrue()
		{
			using (var context = new Context())
			{
				var values = context.Contacts.Where(x => x.ContactStatus == true).ToList();
				return values;
			}
		}
	}
}
