using FluentValidation;
using POS.Application.Dtos.Request;

namespace POS.Application.Validators.Category;

public class CategoryValidators : AbstractValidator<CategoryRequestDtos>
{
	public CategoryValidators()
	{
		RuleFor(x => x.Name)
			.NotNull().WithMessage("El nombre no puede ser nulo.")
			.NotEmpty().WithMessage("El nombre no puede estar vacío.");

	}
}
