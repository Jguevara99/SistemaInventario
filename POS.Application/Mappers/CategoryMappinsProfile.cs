using AutoMapper;
using POS.Application.Dtos.Request;
using POS.Application.Dtos.Response;
using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Response;
using POS.Utilities.Static;

namespace POS.Application.Mappers 
{
	public class CategoryMappinsProfile : Profile
    {
		public CategoryMappinsProfile()
		{
			CreateMap<Category, CategoryResponseDtos>()
					.ForMember(x => x.StateCategory, x => x.MapFrom(y => y.State.Equals((int)StateType.Active) ? "Activo" : "Inactivo"))
					.ReverseMap();

			CreateMap<BaseEntityResponse<Category>, BaseEntityResponse<CategoryResponseDtos>>()
					.ReverseMap();

			CreateMap<CategoryRequestDtos, Category>();

			CreateMap<Category, CategorySelectResponseDtos>()
					.ReverseMap();
		}
    }
}