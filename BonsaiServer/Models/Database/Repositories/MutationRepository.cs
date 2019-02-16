using BonsaiServer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Database
{
    public class MutationRepository : IMutationRepository
    {
        private AppDbContext context;

        public MutationRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Mutation GetMutationbyId(int id)
        {
            return context.Mutations.Find(id);
        }
    }
}
