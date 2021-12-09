using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace UseCases.Core
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        public List<TEntity> Entities { get; set; }
        public IEnumerable<TEntity> GetAll();
        public void Add(TEntity entity);
        public void Update(TEntity entity);
        public void Remove(int entityId);
        public TEntity GetById(int entityId);
        public bool Exists(Func<TEntity, bool> predicate);
    }
}
