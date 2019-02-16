using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Database
{
    interface IMutationRepository
    {
        Mutation GetMutationbyId(int id);
    }
}
