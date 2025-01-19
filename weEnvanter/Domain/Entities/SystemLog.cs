using System;
using weEnvanter.Domain.Common;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Domain.Entities
{
    public class SystemLog : BaseEntity
    {
        public int? UserId { get; set; }
        public DateTime LogDate { get; set; }
        public LogType LogType { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }
        public string EntityName { get; set; }
        public string EntityId { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string IpAddress { get; set; }

        public virtual User User { get; set; }
    }
} 