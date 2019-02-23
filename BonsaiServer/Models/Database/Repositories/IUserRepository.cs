namespace BonsaiServer.Database
{
    public interface IUserRepository
    {
        User GetUserById(int id);

        User GetOwnerOfPlant(Plant plant);

        User GetUserBySession(string session);

        void AddUser(User user);

        bool IsLoginUsed(string login);

        bool IsEmailUsed(string email);

        User GetUserByCredentials(string login, string passwordHash);

        string SetNewSession(User user);
    }
}
