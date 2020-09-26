using College.DataAccess;
using College.Pocos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace College.Logic
{
    public class DepartmentLogic : GenericLogic<Department>
    {
        public DepartmentLogic(IRepository<Department> repository) : base(repository)
        {

        }
        public override void Add(Department entity)
        {
            Verify(entity);
            base.Add(entity);
        }

        public override void Update(Department entity)
        {
            Verify(entity);
            base.Update(entity);
        }

        protected override void Verify(Department entity)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            if (string.IsNullOrEmpty(entity.DepartmentName) || entity.DepartmentName?.Length < 7)
            {
                exceptions.Add(new ValidationException("DepartmentName must be 7 or more char"));
            }
            

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
