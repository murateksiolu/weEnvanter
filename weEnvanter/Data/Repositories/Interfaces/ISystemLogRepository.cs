using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Data.Repositories.Interfaces
{
    public interface ISystemLogRepository : IBaseRepository<SystemLog>
    {
        List<SystemLog> GetLastLogs(int count);
        List<SystemLog> GetLogsByDateRange(System.DateTime startDate, System.DateTime endDate);
        List<SystemLog> GetLogsByUser(int userId);
        List<SystemLog> GetLogsByEntityName(string entityName);
        List<SystemLog> GetLogsByLogType(Domain.Enums.LogType logType);
    }
} 