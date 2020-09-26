using College.DataAccess;
using College.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace College.Logic
{
    public abstract class GenericLogic<TEntity> where TEntity : IAudit
    {
		protected IRepository<TEntity> _repository;
		public GenericLogic(IRepository<TEntity> repository)
		{
			_repository = repository;
		}

		protected virtual void Verify(TEntity entity)
		{
			return;
		}

		public virtual TEntity GetSingle(Guid id)
		{
			return _repository.GetSingle(c => c.Id == id);
		}

		public virtual List<TEntity> GetAll()
		{
			return _repository.GetAll().ToList();
		}

		public virtual void Add(TEntity entity)
		{
			if (entity.Id == Guid.Empty)
			{
				entity.Id = Guid.NewGuid();
			}

			_repository.Add(entity);
		}

		public virtual void Update(TEntity entity)
		{
			_repository.Update(entity);
		}

		public void Delete(TEntity entity)
		{
			_repository.Delete(entity);
		}
	}
}
