using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Database
{
    public interface IPlantRepository
    {
        IEnumerable<Plant> GetPlants();

        Plant GetPlantById(int id);

        IEnumerable<Plant> GetPlantsOfUser(string session);

        void RemovePlantById(int id);

        void AddPlant(Plant plant);

        void MovePlant(int id, byte slot);

        bool IsUserPlant(string session, int plantId);

        void RenamePlant(int plantId, string name);

    }
}
