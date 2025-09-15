using POS.Domain.Entities;
using POS.Infrastructure.Persistences.Contexts;
using POS.Infrastructure.Persistences.Interfaces;

namespace POS.Infrastructure.Persistences.Repositories
{
	public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
	{
		private readonly SISVENTASContext _context;

		public CategoryRepository(SISVENTASContext context)
		{
			_context = context;
		}
	}
}
