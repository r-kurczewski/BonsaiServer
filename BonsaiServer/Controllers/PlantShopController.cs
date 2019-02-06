using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BonsaiServer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BonsaiServer.Controllers
{
    [Route("[controller]")]
    public class PlantShopController : Controller
    {
        private readonly AppSettings _appSettings;
        public PlantShopController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return Ok("OK.");
        }
    }
}