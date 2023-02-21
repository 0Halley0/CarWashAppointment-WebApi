using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.AboutDTOs;
using DTOLayer.DTOs.AppointmentDTOs;
using DTOLayer.DTOs.CarWashDTOs;
using DTOLayer.DTOs.CategoryDTOs;
using DTOLayer.DTOs.ContactDTOs;
using DTOLayer.DTOs.CustomerDTOs;
using FluentValidation;
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

			services.AddScoped<IAppointmentListService, AppointmentListManager>();
			services.AddScoped<IAppointmentListDal, EfAppointmentListRepository>();

			services.AddScoped<ICarWashService, CarWashManager>();
			services.AddScoped<ICarWashDal, EfCarWashRepository>();

			services.AddScoped<ICategoryService, CategoryManager>();
			services.AddScoped<ICategoryDal, EfCategoryRepository>();

			services.AddScoped<IContactService, ContactManager>();
			services.AddScoped<IContactDal, EfContactRepository>();

			services.AddScoped<ICustomerService, CustomerManager>();
			services.AddScoped<ICustomerDal, EfCustomerRepository>();
		}
		public static void CustomValidator(this IServiceCollection services)
		{
			services.AddTransient<IValidator<AboutAddDTO>, AboutValidator>();
			services.AddTransient<IValidator<AppointmentAddDTO>, AppointmentValidator>();
			services.AddTransient<IValidator<CarWashAddDTO>, CarWashValidator>();
			services.AddTransient<IValidator<CategoryAddDTO>, CategoryValidator>();
			services.AddTransient<IValidator<ContactAddDTO>, ContactValidator>();
			services.AddTransient<IValidator<CustomerAddDTO>, CustomerValidator>();
		}
	}
}
