using Microsoft.AspNetCore.Mvc;
using BonsaiServer.Models;
using Microsoft.Extensions.Options;
using BonsaiServer.Database;
using System;

namespace BonsaiServer.Controllers
{
    public class RegisterController : ControllerBase
    {
        private readonly IUserRepository repository;

        public RegisterController(IUserRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public IActionResult Index([FromBody] User user)
        {

            if (repository.IsLoginUsed(user.Login)) return StatusCode(409, "Login is unavailable.");
            if (repository.IsEmailUsed(user.Email)) return StatusCode(409, "Email is unavailable.");
            try
            {
                repository.AddUser(user);
                return Ok($"Account {user.Login} successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}