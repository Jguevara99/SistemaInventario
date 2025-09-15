using AutoMapper;
using POS.Application.Commons.Base;
using POS.Application.Dtos.Request;
using POS.Application.Dtos.Response;
using POS.Application.Interfaces;
using POS.Application.Validators.Category;
using POS.Infrastructure.Commons.Bases.Request;
using POS.Infrastructure.Commons.Bases.Response;
using POS.Infrastructure.Persistences.Interfaces;

namespace POS.Application.Services;

public class CategoryApplication : ICategoryApplication
{

	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;	
	private readonly CategoryValidators _validationRules;

	public CategoryApplication(IUnitOfWork unitOfWork, IMapper mapper, CategoryValidators validationRules)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
		_validationRules = validationRules;
	}

	public Task<BaseResponse<BaseEntityResponse<CategoryResponseDtos>>> ListCategories(BaseFiltersRequest filters)
	{
		throw new NotImplementedException();
	}

	public Task<BaseResponse<IEnumerable<CategorySelectResponseDtos>>> ListSelectCategories()
	{
		throw new NotImplementedException();
	}

	public Task<BaseResponse<CategoryResponseDtos>> CategoryById(int categoryId)
	{
		throw new NotImplementedException();
	}

    public Task<BaseResponse<bool>> RegisterCategory(CategoryRequestDtos requestDto)
	{
		throw new NotImplementedException();
	}

	public Task<BaseResponse<bool>> EditCategory(int categoryId, CategoryRequestDtos requestDto)
	{
		throw new NotImplementedException();
	}

	public Task<BaseResponse<bool>> RemoveCategory(int categoryId)
	{
		throw new NotImplementedException();
	}
}
