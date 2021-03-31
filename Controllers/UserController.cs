using FluentAPI.Interfaces;
using FluentAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("GetUsers")]
        public async Task<IEnumerable<Users>> GetUsers()
        {
            return await userService.GetUsers();
        }

        [HttpPost("CreateUser")]
        public async Task<Users> CreateUser(Users user)
        {
            return await userService.CreateUser(user);
        }

    }
}
