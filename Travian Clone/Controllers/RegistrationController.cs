using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travian_Clone.Enums;
using Travian_Clone.Models;

namespace Travian_Clone.Controllers
{
    [Route("registration")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {

        private readonly UserManager<User> usermanager;
        private readonly RoleManager<IdentityRole> rolemanager;

        public RegistrationController(UserManager<User> manager, RoleManager<IdentityRole> roleManager)
        {
            usermanager = manager;
            rolemanager = roleManager;
        }


        [HttpGet("{username}")]
        public async Task<bool> IsUsernameInUse(string username)
        {
            var user = await usermanager.FindByNameAsync(username);

            if (user != null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        [HttpPost]
        public async Task<bool> Registration(User user)
        {
            var result4 = await usermanager.CreateAsync(user, user.Password);
            var result = await usermanager.AddToRoleAsync(user, "User");
            return result.Succeeded;
        }
    }
}
