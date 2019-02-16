using System.Linq;

namespace BonsaiServer.Database
{
    public class SessionRepository : ISessionRepository
    {
        private AppDbContext context;

        public SessionRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Session GetSessionByCredentials(string login, string passwordHash)
        {
            User cred = context.Users.FirstOrDefault(s => s.Login == login && s.PasswordHash == passwordHash);
            return context.Sessions.FirstOrDefault(s => s.User == cred);
        }
    }
}
