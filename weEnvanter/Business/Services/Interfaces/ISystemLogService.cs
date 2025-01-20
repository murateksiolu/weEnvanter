using System;
using System.Collections.Generic;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Business.Services.Interfaces
{
    public interface ISystemLogService : IBaseService<SystemLog>
    {
        List<SystemLog> GetLastLogs(int count);
        List<SystemLog> GetLogsByDateRange(DateTime startDate, DateTime endDate);
        List<SystemLog> GetLogsByUser(int userId);
        List<SystemLog> GetLogsByEntityName(string entityName);
        List<SystemLog> GetLogsByLogType(LogType logType);
        void LogActivity(int? userId, string action, string description, string entityName = null, string entityId = null, string oldValue = null, string newValue = null, LogType logType = LogType.Information);
    }
} 