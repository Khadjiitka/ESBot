using ESBot.Models;

namespace ESBot.Data;

public interface ISessionRepository
{
    void AddSession(Session session);
    Session? GetSession(int id);
    List<Session> GetSessions();
    void UpdateSession(Session updatedSession);
    void DeleteSession(int id);
}
