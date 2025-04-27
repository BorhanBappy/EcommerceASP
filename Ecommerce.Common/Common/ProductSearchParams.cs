namespace Ecommerce.Common.DTO;

public class ProductSearchParams
{
    public int PageIndex { get; set; } = 1;
    public string? Search { get; set; }
    public string? Column { get; set; }
    public string? OrderBy { get; set; } 
}