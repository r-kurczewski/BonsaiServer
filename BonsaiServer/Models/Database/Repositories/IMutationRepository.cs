namespace BonsaiServer.Database
{
    public interface IMutationRepository
    {
        Mutation GetMutationbyId(int id);

        Mutation GetMutationOfUser(User user);

        void SetMutation(string session, Mutation mutation);

        void Abort(Mutation mutation);

        bool IsUserMutation(string session, int mutationId);

    }
}
