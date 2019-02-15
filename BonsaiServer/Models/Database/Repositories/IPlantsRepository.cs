using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Database
{
    public interface IPlantsRepository
    {
        IEnumerable<Plant> GetPlants();

        Plant GetPlantById(int id);

        void RemoveLastPlant();

        void RemovePlantById(int id);

        void AddPlant(Plant plant);
    }
}
