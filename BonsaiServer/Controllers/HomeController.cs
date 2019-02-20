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


        public ActionResult Add()
        {
            User user = new User()
            {
                Login = "a",
                PasswordHash = "28355A2D1A8636F26EBD23DB7F7BC58F319F8B4D85282DDD308CFC5EEB18031B",
                Email = "abc@wp.pl",
                Session = "IsThisWorking?"
            };
            userRepository.AddUser(user);

            user = userRepository.GetUserByCredentials(user.Login, user.PasswordHash);
            var rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                Plant plant = new Plant()
                {
                    User = user,
                    Name = MutationScript.GenerateName(),
                    FlowersId = 1,
                    LeavesId = 1,
                    StalkColor = BColor.RandomColor(),
                    LeavesColor = BColor.RandomColor(),
                    FlowersColor = BColor.RandomColor(),
                    SoilColor = BColor.RandomColor(),
                    PotColor = BColor.RandomColor(),
                    Rarity = (Rarity.Tier)rand.Next(0, Enum.GetNames(typeof(Rarity.Tier)).Length),
                    Slot = 0,
                };
                plantsRepository.AddPlant(plant);
            }

            Mutation mutation = new Mutation()
            {
                Plant1Id = 1,
                Plant2Id = 2,
                End = new DateTime(2018, 6, 6, 13, 13, 13),
            };
            return Ok("Added start data to database");
        }
    }
}
