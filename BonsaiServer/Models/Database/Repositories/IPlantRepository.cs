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

        void RemoveLastPlant();

        void RemovePlantById(int id);

        void AddPlant(Plant plant);
    }
}
