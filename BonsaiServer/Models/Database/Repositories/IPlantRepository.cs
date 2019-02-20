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

        IEnumerable<Plant> GetPlantsOfUser(User user);

        void RemovePlantById(int id);

        void AddPlant(Plant plant);
    }
}
