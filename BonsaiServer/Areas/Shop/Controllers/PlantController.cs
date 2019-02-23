using BonsaiServer.Database;
using BonsaiServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace BonsaiServer.Controllers
{
    [Area("Shop")]
    public class PlantShop : ControllerBase
    {

        public IActionResult SellPlant([FromBody] AuthData<int> data)
        {
            return Ok(data.Data);
        }

        public IActionResult GetMoney([FromBody] User user)
        {
            return Ok(User);
        }
    }
}