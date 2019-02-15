using BonsaiServer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace BonsaiServer.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly AppSettings appSettings;
        private readonly BonsaiDbContext context;
        public HomeController(BonsaiDbContext context, IOptions<AppSettings> appSettings)
        {
            this.context = context;
            this.appSettings = appSettings.Value;
        }

        public IActionResult Index()
        {
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            
            return Ok($"Bonsai Server: {environment} v.{appSettings.Version}, {JsonConvert.SerializeObject(context.Plants)}");
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
            context.Plants.Add(plant);
            context.SaveChanges();
            return Ok("Added plant");
        }

        public ActionResult Remove()
        {
            context.Plants.Remove(context.Plants.Last());
            context.SaveChanges();
            return Ok("Removed last plant");
        }
    }
}
