using POS.Application.Commons.Base;
using POS.Application.Dtos.Request;
using POS.Application.Dtos.Response;
using POS.Infrastructure.Commons.Bases.Request;
using POS.Infrastructure.Commons.Bases.Response;

namespace POS.Application.Interfaces;

public interface ICategoryApplication
{
	Task<BaseResponse<BaseEntityResponse<CategoryResponseDtos>>> ListCategories(BaseFiltersRequest filters);
	Task<BaseResponse<IEnumerable<CategorySelectResponseDtos>>> ListSelectCategories();
	Task<BaseResponse<CategoryResponseDtos>> CategoryById(int categoryId);
	Task<BaseResponse<bool>> RegisterCategory(CategoryRequestDtos requestDto);
	Task<BaseResponse<bool>> EditCategory(int categoryId, CategoryRequestDtos requestDto);
	Task<BaseResponse<bool>> RemoveCategory(int categoryId);
}
