using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using weEnvanter.Business.Services.Interfaces;
using weEnvanter.Data.Repositories.Interfaces;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Business.Services
{
    public class SystemLogService : BaseService<SystemLog>, ISystemLogService
    {
        private readonly ISystemLogRepository _systemLogRepository;

        public SystemLogService(ISystemLogRepository systemLogRepository) : base(systemLogRepository)
        {
            _systemLogRepository = systemLogRepository;
        }

        public List<SystemLog> GetLastLogs(int count)
        {
            return _systemLogRepository.GetLastLogs(count);
        }

        public List<SystemLog> GetLogsByDateRange(DateTime startDate, DateTime endDate)
        {
            return _systemLogRepository.GetLogsByDateRange(startDate, endDate);
        }

        public List<SystemLog> GetLogsByUser(int userId)
        {
            return _systemLogRepository.GetLogsByUser(userId);
        }

        public List<SystemLog> GetLogsByEntityName(string entityName)
        {
            return _systemLogRepository.GetLogsByEntityName(entityName);
        }

        public List<SystemLog> GetLogsByLogType(LogType logType)
        {
            return _systemLogRepository.GetLogsByLogType(logType);
        }

        public void LogActivity(int? userId, string action, string description, string entityName = null, string entityId = null, string oldValue = null, string newValue = null, LogType logType = LogType.Information)
        {
            var log = new SystemLog
            {
                UserId = userId,
                Action = action,
                Description = description,
                EntityName = entityName,
                EntityId = entityId,
                OldValue = oldValue,
                NewValue = newValue,
                LogType = logType,
                LogDate = DateTime.Now,
                IpAddress = "N/A"
            };

            _systemLogRepository.AddAsync(log);
        }

        public async Task<List<SystemLog>> GetLastLogsAsync(int count)
        {
            return await _systemLogRepository.GetLastLogsAsync(count);
        }
    }
} 