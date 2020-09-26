using College.DataAccess;
using College.Pocos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace College.Logic
{
    public class CourseLogic : GenericLogic<Course>
    {
        public CourseLogic(IRepository<Course> repository) : base(repository)
        {

        }
        public override void Add(Course entity)
        {
            Verify(entity);
            base.Add(entity);
        }

        public override void Update(Course entity)
        {
            Verify(entity);
            base.Update(entity);
        }

        protected override void Verify(Course entity)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            if (string.IsNullOrEmpty(entity.CourseName) || entity.CourseName?.Length < 7)
            {
                exceptions.Add(new ValidationException("Course Name must be 7 or more char"));
            }
            if (entity.Credits > 4)
            {
                exceptions.Add(new ValidationException("Course Credits can't be more than 4"));
            }


            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
