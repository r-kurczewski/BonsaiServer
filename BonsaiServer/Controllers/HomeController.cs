using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using BonsaiServer.Models;
using BonsaiServer.Database;

namespace BonsaiServer.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly AppSettings appSettings;
        private readonly IPlantsRepository plantsRepository;
        public HomeController(IPlantsRepository plantsRepository, IOptions<AppSettings> appSettings)
        {
            this.plantsRepository = plantsRepository;
            this.appSettings = appSettings.Value;
        }

        public IActionResult Index()
        {
            return Ok($"Bonsai Server: v.{appSettings.Version}, {JsonConvert.SerializeObject(plantsRepository.GetPlants())}");
        }

        
        public ActionResult Add()
        {
            Plant plant = new Plant()
            {
                DirtColor = "dbd",
                FlowerColor = "bdb",
                FlowersId = 1,
                LeavesColor = "bdd",
                LeavesId = 1,
                Name = "Politanczykowianka",
                PotColor = "fff",
                Rarity = Rarity.Tier.Premium,
                Slot = 0,
                SoilColor = "111"
            };
            plantsRepository.AddPlant(plant);
            
            return Ok("Added plant");
        }

        public ActionResult Remove()
        {
            plantsRepository.RemoveLastPlant();
            return Ok("Removed last plant");
        }
    }
}
