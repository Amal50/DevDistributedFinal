using College.DataAccess;
using College.Pocos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace College.Logic
{
    public class StudentLogic: GenericLogic<Student>
    {
        public StudentLogic(IRepository<Student> repository) : base(repository)
        {

        }
        public override void Add(Student entity)
        {
            Verify(entity);
            base.Add(entity);
        }

        public override void Update(Student entity)
        {
            Verify(entity);
            base.Update(entity);
        }

        protected override void Verify(Student entity)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            if (string.IsNullOrEmpty(entity.FirstName) || entity.FirstName?.Length < 3)
            {
                exceptions.Add(new ValidationException("First Name must be 3 or more char"));
            }
            if (string.IsNullOrEmpty(entity.LastName) || entity.FirstName?.Length < 3)
            {
                exceptions.Add(new ValidationException("Last Name must be 3 or more char"));
            }

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
