using BonsaiServer.Database;
using BonsaiServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;

namespace BonsaiServer.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly AppSettings appSettings;
        private readonly IPlantRepository plantsRepository;
        private readonly IUserRepository userRepository;
        public HomeController(IPlantRepository plantsRepository, IOptions<AppSettings> appSettings, IUserRepository userRepository)
        {
            this.plantsRepository = plantsRepository;
            this.appSettings = appSettings.Value;
            this.userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return Ok($"Bonsai Server: v.{appSettings.Version}");
        }
    }
}
