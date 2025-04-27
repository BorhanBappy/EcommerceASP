
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Ecommerce.ModelViews;
public class EditModelViews
{
    public Guid Id { get; set; } = Guid.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Email { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; } = string.Empty;
    public string? SelectedRole { get; set; }
    public List<SelectListItem> Roles { get; set; } = new();
}