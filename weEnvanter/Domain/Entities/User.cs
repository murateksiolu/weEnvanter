using System;
using weEnvanter.Domain.Common;
using weEnvanter.Domain.Enums;

namespace weEnvanter.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserRole Role { get; set; }
        public DateTime? LastLoginDate { get; set; }
    }
} 