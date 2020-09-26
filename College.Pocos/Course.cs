using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace College.Pocos
{
    public class Course : IAudit
    {
        public Guid Id { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
