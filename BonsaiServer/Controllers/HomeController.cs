using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using BonsaiServer.Models;
using BonsaiServer.Database;
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


        public ActionResult Add()
        {
            User user = new User()
            {
                Login = "a",
                PasswordHash = "b",
                Email = "abc@wp.pl",
                Session = "c"
            };
            userRepository.CreateUser(user);

            user = userRepository.GetUserByCredentials(user.Login, user.PasswordHash);

            Plant plant = new Plant()
            {
                User = user,
                Name = DateTime.Now.ToString(),
                FlowersId = 1,
                LeavesId = 1,
                LeavesColor = BColor.RandomColor(),
                FlowersColor = BColor.RandomColor(),
                SoilColor = BColor.RandomColor(),
                PotColor = BColor.RandomColor(),
                Rarity = Rarity.Tier.Premium,
                Slot = 0,
            };
            plantsRepository.AddPlant(plant);

            plant = new Plant()
            {
                User = user,
                Name = DateTime.Now.ToString(),
                FlowersId = 1,
                LeavesId = 1,
                LeavesColor = BColor.RandomColor(),
                FlowersColor = BColor.RandomColor(),
                SoilColor = BColor.RandomColor(),
                PotColor = BColor.RandomColor(),
                Rarity = Rarity.Tier.Premium,
                Slot = 0,
            };
            plantsRepository.AddPlant(plant);

            Mutation mutation = new Mutation()
            {
                Plant1Id = 1,
                Plant2Id = 2,
                End = new DateTime(2018, 6, 6, 13, 13, 13),
            };
            return Ok("Added start data to database");
        }

        public ActionResult Remove()
        {
            plantsRepository.RemoveLastPlant();
            return Ok("Removed last plant");
        }
    }
}
