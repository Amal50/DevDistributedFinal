using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace College.Pocos
{
    public class Enrollment : IAudit
    {
        public Guid Id { get; set; }
        public Guid CourseID { get; set; }
        public Guid StudentID { get; set; }
        [ForeignKey("CourseID")]
        public Course Course { get; set; }
        [ForeignKey("StudentID")]
        public Student Student { get; set; }
    }
}
