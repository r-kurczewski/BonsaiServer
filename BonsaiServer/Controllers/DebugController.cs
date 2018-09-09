using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BonsaiServer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BonsaiServer.Controllers
{
    [Route("[Controller]")]
    public class DebugController : Controller
    {
        private readonly AppSettings _appSettings;
        public DebugController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }
        public static Credentials cred = new Credentials("radek", "450a10fad8bc1453cf4690e7391f34df4e7c3621ccc7e1b45699190c6acc36e4");

        [HttpGet]
        public IActionResult Get()
        {
            if(_appSettings.Environment == "Development")
                return Ok(_appSettings);
            else
            {
                return Ok("Access denied.");
            }
        }

        [HttpGet("hex/{hex}")]
        public IActionResult Test (string hex)
        {
            try { return Ok(BColor.RgbFromHex(hex)); }
            catch { return Ok(hex); }
        }
        [HttpGet("hex/rand")]
        public IActionResult RandomHex()
        {
            return Ok(BColor.RandomHex());
        }
    }
}