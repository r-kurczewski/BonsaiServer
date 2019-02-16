namespace BonsaiServer.Database
{
    public interface ISessionRepository
    {
        Session GetSessionByCredentials(string login, string passwordHash);
    }
}
