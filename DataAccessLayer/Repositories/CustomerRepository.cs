using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CustomerRepository : IGenericDal<Customer>
    {
        public void Delete(Customer t)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Customer t)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer t)
        {
            throw new NotImplementedException();
        }
    }
}
