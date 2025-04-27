using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entity.Models;

public class PasswordModelView
{
    [Required(ErrorMessage = "The New current password is required."), MaxLength(100)]
    public string CurrentPassword { get; set; } = "";
    [Required(ErrorMessage = "The New password is required."), MaxLength(100)]
    public string NewPassword { get; set; } = "";

    [Required(ErrorMessage = "The Confirm password is required.")]
    [Compare("NewPassword", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; } = "";
}