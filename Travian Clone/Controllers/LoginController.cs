using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travian_Clone.Models;

namespace Travian_Clone.Controllers
{
    [Route("login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserManager<User> usermanager;
        private readonly SignInManager<User> signinmanager;

        public LoginController(UserManager<User> manager, SignInManager<User> signInManager)
        {
            usermanager = manager;
            signinmanager = signInManager;
        }

        [HttpPost]
        public async Task<Microsoft.AspNetCore.Identity.SignInResult> Login(User user)
        {
            var result = await signinmanager.PasswordSignInAsync(user.UserName, user.Password, false, false);
            return result;
        }

        [HttpGet]
        public async Task<IActionResult> CheckLoginStatus()
        {
            var user = this.User;
            if (user.IsInRole("User"))
            {
                return Ok(new { username = user.Identity.Name, isAdmin = false, isLoggedIn=true });
            }
            else if (user.IsInRole("Admin"))
            {
                return Ok(new { username = user.Identity.Name, isAdmin = true , isLoggedIn = true});
            }
            return Ok(new { username = "", isAdmin = false, isLoggedIn = false });
        }

        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            await signinmanager.SignOutAsync();
            return Ok(new { success = true });
        }
    }
}
