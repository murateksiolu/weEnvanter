using System.Collections.Generic;
using weEnvanter.Domain.Common;

namespace weEnvanter.Domain.Entities
{
    public class Department : BaseEntity
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
            SubDepartments = new HashSet<Department>();
        }

        public string Name { get; set; }
        public string DepartmentCode { get; set; }
        public string Description { get; set; }
        public int? ParentDepartmentId { get; set; }

        public virtual Department ParentDepartment { get; set; }
        public virtual ICollection<Department> SubDepartments { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
} 