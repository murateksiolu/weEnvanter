using System;
using weEnvanter.Domain.Common;

namespace weEnvanter.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeNumber { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Notes { get; set; }
        public int DepartmentId { get; set; }
        public DateTime HireDate { get; set; }

        public virtual Department Department { get; set; }
    }
} 