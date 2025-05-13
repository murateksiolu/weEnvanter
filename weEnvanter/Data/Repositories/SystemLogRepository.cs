using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using weEnvanter.Data.Repositories.Interfaces;
using weEnvanter.Domain.Entities;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Data.Repositories
{
    public class SystemLogRepository : BaseRepository<SystemLog>, ISystemLogRepository
    {
        public SystemLogRepository(WeEnvanterDbContext context) : base(context)
        {
        }

        public List<SystemLog> GetLastLogs(int count)
        {
            return _context.SystemLogs
                .OrderByDescending(x => x.LogDate)
                .Take(count)
                .ToList();
        }

        public List<SystemLog> GetLogsByDateRange(DateTime startDate, DateTime endDate)
        {
            return _context.SystemLogs
                .Where(x => x.LogDate >= startDate && x.LogDate <= endDate)
                .OrderByDescending(x => x.LogDate)
                .ToList();
        }

        public List<SystemLog> GetLogsByUser(int userId)
        {
            return _context.SystemLogs
                .Where(x => x.UserId == userId)
                .OrderByDescending(x => x.LogDate)
                .ToList();
        }

        public List<SystemLog> GetLogsByEntityName(string entityName)
        {
            return _context.SystemLogs
                .Where(x => x.EntityName == entityName)
                .OrderByDescending(x => x.LogDate)
                .ToList();
        }

        public List<SystemLog> GetLogsByLogType(LogType logType)
        {
            return _context.SystemLogs
                .Where(x => x.LogType == logType)
                .OrderByDescending(x => x.LogDate)
                .ToList();
        }

        public async Task<List<SystemLog>> GetLastLogsAsync(int count)
        {
            return await _dbSet.OrderByDescending(x => x.CreatedDate)
                              .Take(count)
                              .ToListAsync();
        }
    }
} 