using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Entity.Models;

public class ApplicationUser:IdentityUser<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public DateTime CreatedAt { get; set; }
}