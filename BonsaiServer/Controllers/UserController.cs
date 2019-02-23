using BonsaiServer.Database;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BonsaiServer.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly IUserRepository repository;

        public UserController(IUserRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public IActionResult Login([FromBody]User cred)
        {
            User user = repository.GetUserByCredentials(cred.Login, cred.PasswordHash);
            repository.SetNewSession(user);
            if (user != null) return Ok(user);
            else return StatusCode(400, "Login Error");
        }

        [HttpPost]
        public IActionResult Register([FromBody] User user)
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
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult CheckName(User user)
        {
            if (repository.IsLoginUsed(user.Login))
            {
                return StatusCode(409, $"Login {user.Login} is used");
            }
            else
            {
                return Ok($"Login {user.Login} is not used.");
            }
        }
    }
}