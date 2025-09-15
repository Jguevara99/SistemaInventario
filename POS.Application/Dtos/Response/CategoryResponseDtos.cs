namespace POS.Application.Dtos.Response;

public class CategoryResponseDtos
{
	public int CategoryId { get; set; }
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	public DateTime AuditCreateDate { get; set; }
	public int State { get; set; }
	public string StateCategory { get; set; } = string.Empty;
}
