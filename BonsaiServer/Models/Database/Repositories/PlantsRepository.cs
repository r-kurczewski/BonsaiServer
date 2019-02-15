using System.Collections.Generic;
using System.Linq;

namespace BonsaiServer.Database
{
    public class PlantsRepository : IPlantsRepository
    {
        private readonly AppDbContext context;

        public PlantsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddPlant(Plant plant)
        {
            context.Plants.Add(plant);
            context.SaveChanges();
        }

        public Plant GetPlantById(int id)
        {
            return context.Plants.Find(id);
        }

        public IEnumerable<Plant> GetPlants()
        {
            return context.Plants;
        }

        public void RemoveLastPlant()
        {
            context.Remove(context.Plants.Last());
            context.SaveChanges();
        }

        public void RemovePlantById(int id)
        {
            context.Plants.Remove(context.Plants.Find(id));
            context.SaveChanges();
        }
    }
}
