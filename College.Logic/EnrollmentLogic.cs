using College.DataAccess;
using College.Pocos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace College.Logic
{
    public class EnrollmentLogic : GenericLogic<Enrollment>
    {
        public EnrollmentLogic(IRepository<Enrollment> repository) : base(repository)
        {

        }
        public override void Add(Enrollment entity)
        {
            Verify(entity);
            base.Add(entity);
        }

        public override void Update(Enrollment entity)
        {
            Verify(entity);
            base.Update(entity);
        }

        protected override void Verify(Enrollment entity)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            if (entity.CourseID == null)
            {
                exceptions.Add(new ValidationException("Course can't be null"));
            }

            if (entity.StudentID == null)
            {
                exceptions.Add(new ValidationException("Student can't be null"));
            }

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
