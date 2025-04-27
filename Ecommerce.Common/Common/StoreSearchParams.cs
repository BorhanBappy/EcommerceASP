namespace Ecommerce.Entity.Models;

public class StoreSearchParams
{
    public int PageIndex { get; set; } = 1;
    public string? Search { get; set; }
    public string? Brand { get; set; }
    public string? Category { get; set; }
    public string? Sort { get; set; }
}