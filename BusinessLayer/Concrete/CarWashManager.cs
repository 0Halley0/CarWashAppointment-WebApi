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
	public class CarWashManager : ICarWashService
	{
		private readonly ICarWashDal _carWashDal;

		public CarWashManager(ICarWashDal carWashDal)
		{
			_carWashDal = carWashDal;
		}

		public void TAdd(CarWash t)
		{
			_carWashDal.Insert(t);
		}

		public void TDelete(CarWash t)
		{
			_carWashDal.Delete(t);
		}

		public List<CarWash> TGetAll()
		{
			return _carWashDal.GetAll();
		}

		public CarWash TGetById(int id)
		{
			return _carWashDal.GetById(id);
		}

		public void TUpdate(CarWash t)
		{
			_carWashDal.Update(t);
		}
	}
}
