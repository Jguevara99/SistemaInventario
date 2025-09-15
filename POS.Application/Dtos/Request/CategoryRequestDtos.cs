namespace POS.Application.Dtos.Request;

public class CategoryRequestDtos
{
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	public int State { get; set; }
}
