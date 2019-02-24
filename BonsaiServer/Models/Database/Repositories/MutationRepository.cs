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

        public void Abort(int mutationId)
        {
            context.Mutations.Remove(context.Mutations.Find(mutationId));
        }

        public Mutation GetMutationbyId(int id)
        {
            return context.Mutations.Find(id);
        }

        public Mutation GetMutationOfUser(string session)
        {
            return context.Mutations.FirstOrDefault(s => s.User.Session == session);
        }

        public bool IsUserMutation(string session, int mutationId)
        {
            return context.Users.FirstOrDefault(s => s.Session == session).Id == mutationId;
        }


        public void SetMutation(string session, Mutation mutation)
        {
            if (context.Users.FirstOrDefault(s => s.Session == session).Id != mutation.Id)
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
