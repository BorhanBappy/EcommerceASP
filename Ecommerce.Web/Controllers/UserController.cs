using Ecommerce.Entity.Models;
using Ecommerce.Entity.Models;
using Ecommerce.ModelViews;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ecommerce.Controllers;

[Authorize(Roles = "Admin")]
[Route("/Admin/[controller]/{action=Index}/{id?}")]
public class UserController : Controller
{
    private readonly UserManager<ApplicationUser> userManager;
    private readonly RoleManager<ApplicationRole> roleManager;

    public UserController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
    {
        this.userManager = userManager;
        this.roleManager = roleManager;
    }

    // GET
    public IActionResult Index()
    {
        var user = userManager.Users.OrderByDescending(u => u.CreatedAt).ToList();
        return View(user);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(string id)
    {
        var user = await userManager.FindByIdAsync(id);
        if (user == null)
        {
            return RedirectToAction("Index");
        }

        var userRoles = await userManager.GetRolesAsync(user);
        var allRoles = roleManager.Roles.ToList();

        var model = new EditModelViews
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            PhoneNumber = user.PhoneNumber,
            SelectedRole = userRoles.FirstOrDefault(), // Assuming one role per user
            Roles = allRoles.Select(r => new SelectListItem
            {
                Value = r.Name,
                Text = r.Name
            }).ToList()
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(EditModelViews model)
    {
        if (!ModelState.IsValid)
        {
            model.Roles = roleManager.Roles.Select(r => new SelectListItem
            {
                Value = r.Name,
                Text = r.Name
            }).ToList();
            return View(model);
        }

        if (model.Email != null)
        {
            var user = await userManager.FindByIdAsync(model.Id.ToString());
            if (user == null)
            {
                return RedirectToAction("Index");
            }

            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.PhoneNumber = model.PhoneNumber;

            var result = await userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                return View(model);
            }

            var currentRoles = await userManager.GetRolesAsync(user);
            if (!string.IsNullOrEmpty(model.SelectedRole) && !currentRoles.Contains(model.SelectedRole))
            {
                await userManager.RemoveFromRolesAsync(user, currentRoles);
                await userManager.AddToRoleAsync(user, model.SelectedRole);
            }
        }

        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Delete(string id)
    {
        var user = await userManager.FindByIdAsync(id);
        if (user == null)
        {
            return RedirectToAction("Index");
        }

        var result = await userManager.DeleteAsync(user);
        if (result.Succeeded)
        {
            return RedirectToAction("Index");
        }

        // Handle errors if deletion fails
        TempData["Error"] = "Failed to delete the user.";
        return RedirectToAction("Index");
    }
}