using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travian_Clone.Models;

namespace Travian_Clone.Controllers
{
    [Route("test")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class TestController : ControllerBase
    {

        private readonly UserManager<User> usermanager;
        private readonly RoleManager<IdentityRole> rolemanager;

        public TestController(UserManager<User> manager, RoleManager<IdentityRole> roleManager, TravianCloneContext travianCloneContext)
        {
            usermanager = manager;
            rolemanager = roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> StartLiveStreamRecord()
        {
            return Ok(new { isAdmin = this.User.IsInRole("Admin") });
        }

    }
}
