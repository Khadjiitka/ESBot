using ESBot.Models;
using Microsoft.EntityFrameworkCore;

namespace ESBot.Data;

public class SessionRepository : ISessionRepository
{
        private IDbContextFactory<SessionContext> _contextFactory;
        public SessionRepository(IDbContextFactory<SessionContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }
    public void AddSession(Session session)
    {
        using var db = _contextFactory.CreateDbContext();
        db.Sessions.Add(session);
        db.SaveChanges();
    }

    public Session? GetSession(int id)
    {
        using var db = _contextFactory.CreateDbContext();
        return db.Sessions.Find(id);
    }

    public List<Session> GetSessions()
    {
        using var db = _contextFactory.CreateDbContext();
        return db.Sessions.ToList();
    }

    public void UpdateSession(Session updatedSession)
    {
        using var db = _contextFactory.CreateDbContext();
        var existingSession = db.Sessions.Find(updatedSession.Id);

        if (existingSession is null)
        {
            return;
        }

        existingSession.Name = updatedSession.Name;
        existingSession.Text = updatedSession.Text;
        db.SaveChanges();
    }

    public void DeleteSession(int id)
    {
        using var db = _contextFactory.CreateDbContext();
        var session = db.Sessions.Find(id);

        if (session is null)
        {
            return;
        }

        db.Sessions.Remove(session);
        db.SaveChanges();
    }
}
