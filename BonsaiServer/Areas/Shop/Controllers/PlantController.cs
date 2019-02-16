using System.Diagnostics;
using BonsaiServer.Database;
using BonsaiServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BonsaiServer.Controllers
{
    [Area("Shop")]
    public class PlantShop : ControllerBase
    {

        public IActionResult SellPlant([FromBody] AuthData<int> data)
        {
            return Ok(data.data);
        }

        public IActionResult GetMoney([FromBody] User user)
        {
            return Ok(User);
        }
    }
}