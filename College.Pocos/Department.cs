using System;
using System.Collections.Generic;
using System.Text;

namespace College.Pocos
{
    public class Department : IAudit
    {
        public Guid Id { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
