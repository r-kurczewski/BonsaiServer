using BonsaiServer.Database;
using BonsaiServer.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BonsaiServer.Controllers
{
    public class MutationController : ControllerBase
    {
        private readonly IMutationRepository mutationRepository;
        private readonly IPlantRepository plantRepository;

        public MutationController(IMutationRepository mutationRepository, IPlantRepository plantRepository)
        {
            this.mutationRepository = mutationRepository;
            this.plantRepository = plantRepository;
        }

        [HttpPost]
        public IActionResult Get([FromBody] string session)
        {
            try
            {
                Mutation mutation = mutationRepository.GetMutationOfUser(session);
                if (mutation == null) return StatusCode(204, "No mutation in progress.");
                return Ok(mutation);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Set([FromBody] AuthData<Mutation> data)
        {
            try
            {
                mutationRepository.SetMutation(data.Session, data.Data);
                return Ok("Success.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Collect([FromBody] AuthData<int> data)
        {
            try
            {
                if (!mutationRepository.IsUserMutation(data.Session, data.Data))
                    throw new UnauthorizedAccessException();

                Mutation mutation = mutationRepository.GetMutationbyId(data.Data);
                Plant plant1 = mutation.Plant1;
                Plant plant2 = mutation.Plant2;
                Plant newPlant = MutationScript.Cross(plant1, plant2);
                plantRepository.AddPlant(newPlant);
                return Ok(newPlant);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        public IActionResult Abort([FromBody] AuthData<int> id)
        {
            try
            {
                if (mutationRepository.IsUserMutation(id.Session, id.Data))
                    mutationRepository.Abort(id.Data);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }
    }
}