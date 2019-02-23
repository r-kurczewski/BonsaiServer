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

        public IEnumerable<Plant> GetPlantsOfUser(User user)
        {
            return context.Plants.Where(plant => plant.User.Session == user.Session).ToList();
        }

        public bool IsUserPlant(User user, int plantId)
        {
            return context.Plants.Find(plantId).UserId == context.Users.FirstOrDefault(s => s.Session == user.Session).Id;
        }

        public void MovePlant(int id, byte slot)
        {
            context.Plants.Find(id).Slot = slot;
            context.SaveChanges();
        }

        public void RemovePlantById(int id)
        {
            context.Plants.Remove(context.Plants.Find(id));
            context.SaveChanges();
        }

        public void RenamePlant(Plant plant, string name)
        {
            context.Plants.Find(plant.Id).Name = name;
            context.SaveChanges();
        }
    }
}
