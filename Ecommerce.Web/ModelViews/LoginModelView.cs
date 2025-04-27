using System.ComponentModel.DataAnnotations;

namespace Ecommerce.ModelViews;

public class LoginModelView
{
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    public bool RememberMe { get; set; }= false;
}