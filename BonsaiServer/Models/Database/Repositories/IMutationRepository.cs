namespace BonsaiServer.Database
{
    public interface IMutationRepository
    {
        Mutation GetMutationbyId(int id);

        Mutation GetMutationOfUser(User user);

        void SetMutation(User user, Mutation mutation);

        void Abort(Mutation mutation);

        bool IsUserMutation(User user, int mutationId);

    }
}
