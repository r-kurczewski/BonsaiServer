using System;
using Microsoft.AspNetCore.Mvc;

using BonsaiServer.Models;
using Microsoft.Extensions.Options;
using BonsaiServer.Database;

namespace BonsaiServer.Controllers
{
    public class LoginController : ControllerBase
    {
        private readonly IUserRepository repository;

        public LoginController(IUserRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public IActionResult Index([FromBody]User cred)
        {
            User user = repository.GetUserByCredentials(cred.Login, cred.PasswordHash);
            if (!user.Equals(null)) return Ok(user);
            else return StatusCode(400, "Login Error");
        }
    }
}