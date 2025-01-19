using System.Collections.Generic;
using weEnvanter.Domain.Common;

namespace weEnvanter.Domain.Entities
{
    public class Department : BaseEntity
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
} 