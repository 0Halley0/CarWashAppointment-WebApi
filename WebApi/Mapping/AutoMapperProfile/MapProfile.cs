using AutoMapper;
using DTOLayer.DTOs.AboutDTOs;
using DTOLayer.DTOs.AppointmentDTOs;
using DTOLayer.DTOs.CarWashDTOs;
using DTOLayer.DTOs.CategoryDTOs;
using DTOLayer.DTOs.ContactDTOs;
using DTOLayer.DTOs.CustomerDTOs;
using EntityLayer.Concrete;

namespace WebApi.Mapping.AutoMapperProfile
{
	public class MapProfile : Profile
	{
		protected MapProfile()
		{
			CreateMap<AboutAddDTO, About>();
			CreateMap<About,AboutAddDTO>();

			CreateMap<AppointmentAddDTO, Appointment>();
			CreateMap<Appointment, AppointmentAddDTO>();

			CreateMap<AppointmentListDTO, AppointmentList>();
			CreateMap<AppointmentList, AppointmentListDTO>();

			CreateMap<CarWashAddDTO, CarWash>();
			CreateMap<CarWash,CarWashAddDTO>();

			CreateMap<CategoryAddDTO, Category>();
			CreateMap<Category,CategoryAddDTO>();

			CreateMap<ContactAddDTO, Contact>();
			CreateMap<Contact, ContactAddDTO>();

			CreateMap<CustomerAddDTO, Customer>();
			CreateMap<Customer, CustomerAddDTO>();
			CreateMap<CustomerListDTO, Customer>();
			CreateMap<Customer, CustomerListDTO>();
		}
	}
}
