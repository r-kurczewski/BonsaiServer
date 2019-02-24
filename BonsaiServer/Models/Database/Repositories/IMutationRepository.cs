namespace BonsaiServer.Database
{
    public interface IMutationRepository
    {
        Mutation GetMutationbyId(int id);

        Mutation GetMutationOfUser(string session);

        void SetMutation(string session, Mutation mutation);

        void Abort(int mutationId);

        bool IsUserMutation(string session, int mutationId);

    }
}
