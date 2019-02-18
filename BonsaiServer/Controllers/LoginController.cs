using System;
using Microsoft.AspNetCore.Mvc;

using BonsaiServer.Models;
using Microsoft.Extensions.Options;
using BonsaiServer.Database;

namespace BonsaiServer.Controllers
{
    public class LoginController : ControllerBase
    {
        private readonly ISessionRepository repository;

        public LoginController(ISessionRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public IActionResult Index([FromBody]User cred)
        {
            Session session = repository.GetSessionByCredentials(cred.Login, cred.PasswordHash);
            if (!session.Equals(null)) return Ok(session);
            else return StatusCode(400, "Login Error");
        }
    }
}