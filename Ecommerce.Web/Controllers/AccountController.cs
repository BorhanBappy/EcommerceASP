using System.ComponentModel.DataAnnotations;
using Ecommerce.Entity.Models;
using Ecommerce.ModelViews;
using Ecommerce.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<ApplicationUser> userManager;
    private readonly SignInManager<ApplicationUser> signInManager;
    private readonly IConfiguration configuration;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
        IConfiguration configuration)
    {
        this.userManager = userManager;
        this.signInManager = signInManager;
        this.configuration = configuration;
    }

    // GET
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterModelView registerModelView)
    {
        if (!ModelState.IsValid)
        {
            return View(registerModelView);
        }

        var user = new ApplicationUser
        {
            UserName = registerModelView.Email,
            Email = registerModelView.Email,
            FirstName = registerModelView.FirstName,
            LastName = registerModelView.LastName,
            Address = registerModelView.Address,
            CreatedAt = DateTime.Now
        };

        var result = await userManager.CreateAsync(user, registerModelView.Password);
        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(user, "Client");
            await signInManager.SignInAsync(user, false);
            return RedirectToAction("Index", "Home");
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError("", error.Description);
        }

        return View(registerModelView);
    }

    public async Task<IActionResult> Logout()
    {
        if (signInManager.IsSignedIn(User))
        {
            await signInManager.SignOutAsync();
        }

        return RedirectToAction("Index", "Home");
    }

    public async Task<IActionResult> Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginModelView loginModelView)
    {
        if (!ModelState.IsValid)
        {
            return View(loginModelView);
        }

        string? returnTo = Request.Query.ContainsKey("returnUrl")
            ? "/" + Request.Query["returnUrl"].ToString()
            : Url.Action("Index", "Home");    

        var result =
            await signInManager.PasswordSignInAsync(loginModelView.Email, loginModelView.Password, loginModelView.RememberMe, false);
        if (result.Succeeded)
        {
            return Redirect(returnTo!);
        }
        else
        {
            ViewBag.ErrorMessage = "Invalid login attempt";
        }

        return View(loginModelView);
    }


    [Authorize]
    public async Task<IActionResult> Profile()
    {
        var appUser = await userManager.GetUserAsync(User);
        if (appUser == null)
        {
            return RedirectToAction("Index", "Home");
        }

        var profileDto = new ProfileModelView
        {
            FirstName = appUser.FirstName,
            LastName = appUser.LastName,
            Email = appUser.Email ?? "",
            PhoneNumber = appUser.PhoneNumber,
            Address = appUser.Address
        };
        return View(profileDto);
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Profile(ProfileModelView profileModelView)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.ErrorMessage = "Invalid login attempt";
            return View(profileModelView);
        }

        var appUser = await userManager.GetUserAsync(User);
        if (appUser == null)
        {
            return RedirectToAction("Index", "Home");
        }

        //update user
        appUser.FirstName = profileModelView.FirstName;
        appUser.LastName = profileModelView.LastName;
        appUser.Email = profileModelView.Email;
        appUser.UserName = profileModelView.Email;
        appUser.PhoneNumber = profileModelView.PhoneNumber;
        appUser.Address = profileModelView.Address;
        var result = await userManager.UpdateAsync(appUser);
        if (result.Succeeded)
        {
            ViewBag.successMessage = "Profile updated successfully";
        }
        else
        {
            ViewBag.errorMessage = "Failed to update profile" + result.Errors.First().Description;
        }

        return View(profileModelView);
    }

    public IActionResult AccessDenied()
    {
        return RedirectToAction("Index", "Home");
    }

    [Authorize]
    public IActionResult Password()
    {
        return View();
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Password(PasswordModelView passwordModelView)
    {
        if (!ModelState.IsValid)
        {
            return View(passwordModelView);
        }

        //get the user
        var appUser = await userManager.GetUserAsync(User);
        if (appUser == null)
        {
            return RedirectToAction("Index", "Home");
        }

        //uppdate password
        var result =
            await userManager.ChangePasswordAsync(appUser, passwordModelView.CurrentPassword, passwordModelView.NewPassword);
        if (result.Succeeded)
        {
            ViewBag.successMessage = "Password updated successfully";
            await signInManager.SignInAsync(appUser, false);
        }
        else
        {
            ViewBag.errorMessage = "Failed to current password" + result.Errors.First().Description;
        }

        return View();
    }


    public IActionResult ForgetPassword()
    {
        if (signInManager.IsSignedIn(User))
        {
            return RedirectToAction("Index", "Home");
        }

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> ForgetPassword([Required, EmailAddress] string email)
    {
        if (signInManager.IsSignedIn(User))
        {
            return RedirectToAction("Index", "Home");
        }

        ViewBag.Email = email;
        if (!ModelState.IsValid)
        {
            ViewBag.EmailError = ModelState["email"]?.Errors.First().ErrorMessage ?? "invalid email";
            return View();
        }

        var user = await userManager.FindByEmailAsync(email);
        if (user != null)
        {
            var token = await userManager.GeneratePasswordResetTokenAsync(user);
            string resetUrl = Url.ActionLink("ResetPassword", "Account", new { token = token }) ?? "url Error";
            // send url by email
            string senderName = configuration["BrevoSettings:SenderName"] ?? "";
            string senderEmail = configuration["BrevoSettings:SenderEmail"] ?? "";
            string username = user.FirstName + " " + user.LastName;
            string subject = "Password Reset";
            string message = "Dear " + username + ",\n\n" +
                             "You can reset your password using the following link:\n\n" +
                             resetUrl + "\n\n" +
                             "Best Regards";

            EmailSender.SendEmail(senderName, senderEmail, username, email, subject, message);
        }

        ViewBag.SuccessMessage = "Please check your Email account and click on the Password Reset link!";

        return View();
    }

    
}