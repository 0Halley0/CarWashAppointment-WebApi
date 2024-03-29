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
	public class CustomerManager : ICustomerService
	{
		private readonly ICustomerDal _customerDal;

		public CustomerManager(ICustomerDal customerDal)
		{
			_customerDal = customerDal;
		}

		public Customer GetByEmail(string email)
		{
			return _customerDal.GetByEmail(email);
		}

		public Customer GetByPlateNumber(string plateNumber)
		{
			throw new NotImplementedException();
		}

		public void TAdd(Customer t)
		{
			_customerDal.Insert(t);
		}

		public void TDelete(Customer t)
		{
			_customerDal.Delete(t);
		}

		public List<Customer> TGetAll()
		{
			return _customerDal.GetAll();
		}

		public Customer TGetById(int id)
		{
			return _customerDal.GetById(id);
		}

		public void TUpdate(Customer t)
		{
			_customerDal.Update(t);
		}
	}
}
