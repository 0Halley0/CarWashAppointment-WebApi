using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
	public static class Extensions
	{
		public static void ContainerDependencies(this IServiceCollection services)
		{
			services.AddScoped<IAboutService,AboutManager>();
			services.AddScoped<IAboutDal,EfAboutRepository>();

			services.AddScoped<IAppointmentService, AppointmentManager>();
			services.AddScoped<IAppointmentDal, EfAppointmentRepository>();

			services.AddScoped<ICarWashService, CarWashManager>();
			services.AddScoped<ICarWashDal, EfCarWashRepository>();

			services.AddScoped<ICategoryService, CategoryManager>();
			services.AddScoped<ICategoryDal, EfCategoryRepository>();

			services.AddScoped<IContactService, ContactManager>();
			services.AddScoped<IContactDal, EfContactRepository>();

			services.AddScoped<ICustomerService, CustomerManager>();
			services.AddScoped<ICustomerDal, EfCustomerRepository>();
		}
	}
}
