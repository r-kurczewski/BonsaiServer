using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BonsaiServer.Database;
using System.Linq;
using System;
using BonsaiServer.Models;

namespace BonsaiServer.Controllers
{
    public class PlantsController : ControllerBase
    {
        private readonly IPlantRepository repository;
        public PlantsController(IPlantRepository repository)
        {
            this.repository = repository;
        }
        [HttpPost]
        public IActionResult Get([FromBody] User user)
        {
            List<Plant> plants;
            try
            {
                plants = repository.GetPlantsOfUser(user).ToList();
                if (plants.Count == 0)
                {
                    return StatusCode(204, "No plants to get.");
                }
                else
                {
                    return Ok(plants);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }

        }

        [HttpPost]
        public IActionResult Move([FromBody] AuthData<List<int[]>> updates)
        {
            try
            {
                foreach (var arr in updates.Data)
                {
                    if (repository.IsUserPlant(updates.User, arr[0]))
                        repository.MovePlant(arr[0], (byte)arr[1]);
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Rename([FromBody] AuthData<Dictionary<int, string>> data)
        {
            try
            {
                foreach (var plant in data.Data)
                {
                    if (repository.IsUserPlant(data.User, plant.Key)) repository.RenamePlant(new Plant { Id = plant.Key }, plant.Value);
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }
    }
}