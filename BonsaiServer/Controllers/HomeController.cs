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
        public HomeController(IPlantRepository plantsRepository, IOptions<AppSettings> appSettings)
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
                Name = DateTime.Now.ToString(),
                FlowersId = 1,
                LeavesId = 1,
                LeavesColor = BColor.RandomColor(),
                FlowerColor = BColor.RandomColor(),
                DirtColor = BColor.RandomColor(),
                SoilColor = BColor.RandomColor(),
                PotColor = BColor.RandomColor(),
                Rarity = Rarity.Tier.Premium,
                Slot = 0,
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
