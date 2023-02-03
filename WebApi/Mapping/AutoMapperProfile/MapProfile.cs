using AutoMapper;
using DTOLayer.DTOs.CategoryDTOs;
using DTOLayer.DTOs.CustomerDTOs;
using EntityLayer.Concrete;

namespace WebApi.Mapping.AutoMapperProfile
{
	public class MapProfile : Profile
	{
		protected MapProfile()
		{
			CreateMap<CategoryAddDTOs, Category>();
			CreateMap<Category, CategoryAddDTOs>();
		}
	}
}
