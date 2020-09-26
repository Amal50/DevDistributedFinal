using System;
using System.Collections.Generic;
using System.Text;

namespace College.Pocos
{
    public class Student : IAudit
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
