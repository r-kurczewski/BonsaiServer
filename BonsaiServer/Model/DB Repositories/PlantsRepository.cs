using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Model
{
    public class PlantsRepository : IPlantsRepository
    {
        private BonsaiDbContext context;

        public PlantsRepository(BonsaiDbContext context)
        {
            this.context = context;
        }

        public Plant GetPlantById(int id)
        {
            return context.Plants.FirstOrDefault( s => s.Id == id);
        }

        public IEnumerable<Plant> GetPlants()
        {
            return context.Plants;
        }
    }
}
