using System.Collections.Generic;
using System.Linq;

namespace BonsaiServer.Database
{
    public class PlantRepository : IPlantRepository
    {
        private readonly AppDbContext context;

        public PlantRepository(AppDbContext context)
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

        public IEnumerable<Plant> GetPlantsOfUser(Session session)
        {
            session = context.Sessions.FirstOrDefault(s => s.SessionHash == session.SessionHash);
            return context.Plants.Where(plant => plant.User == session.User);
        }

        public void RemoveLastPlant()
        {
            if (context.Plants.Count() > 0)
            { 
                context.Remove(context.Plants.Last());
                context.SaveChanges();
            }
        }

        public void RemovePlantById(int id)
        {
            context.Plants.Remove(context.Plants.Find(id));
            context.SaveChanges();
        }
    }
}
