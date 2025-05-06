using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entity.Models;

public class CheckoutViewModel
{
    [Required(ErrorMessage = "The Delivery Address is required.")]
    [MaxLength(200)]
    public string DeliveryAddress { get; set; } = "";
    public string PaymentMethod { get; set; } = "";
}