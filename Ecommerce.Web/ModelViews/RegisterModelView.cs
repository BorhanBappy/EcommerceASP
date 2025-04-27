using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entity.Models;

public class RegisterModelView
{
    [Required(ErrorMessage = "First name is required."), MaxLength(100)]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last name is required."), MaxLength(100)]
    public string LastName { get; set; }

    [Required, EmailAddress, MaxLength(100)]
    public string Email { get; set; }

    public string? PhoneNumber { get; set; }

    [Required(ErrorMessage = "Address is required."), MaxLength(200)]
    public string Address { get; set; } = "";

    [Required, MaxLength(100)] public string Password { get; set; } = ""; 

    [Required(ErrorMessage = "The Confirm password is required.")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; } ="";
}