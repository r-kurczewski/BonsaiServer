using System;
using System.Linq;

namespace BonsaiServer.Database
{
    public class MutationRepository : IMutationRepository
    {
        private AppDbContext context;

        public MutationRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Abort(Mutation mutation)
        {
            context.Mutations.Remove(context.Mutations.Find(mutation.Id));
        }

        public Mutation GetMutationbyId(int id)
        {
            return context.Mutations.Find(id);
        }

        public Mutation GetMutationOfUser(User user)
        {
            return context.Mutations.FirstOrDefault(s => s.User.Session == user.Session);
        }

        public bool IsUserMutation(User user, int mutationId)
        {
            return context.Users.FirstOrDefault(s => s.Session == user.Session).Id == mutationId;
        }

        public void SetMutation(User user, Mutation mutation)
        {
            if (context.Users.FirstOrDefault(s => s.Session == user.Session).Id != mutation.Id)
                throw new UnauthorizedAccessException("Id mismatch");
            if (context.Plants.FirstOrDefault(s => s.UserId == mutation.Plant1.UserId) == null)
                throw new NullReferenceException("Wrong plant1.");
            if (context.Plants.FirstOrDefault(s => s.UserId == mutation.Plant2.UserId) == null)
                throw new NullReferenceException("Wrong plant2.");
            context.Mutations.Add(mutation);
            context.SaveChanges();
        }
    }
}
