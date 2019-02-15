using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Model
{
    interface IPlantsRepository
    {
        IEnumerable<Plant> GetPlants();

        Plant GetPlantById(int id);
    }
}
