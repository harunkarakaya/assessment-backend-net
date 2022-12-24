using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        TEntity GetById(string id);
        void Update(TEntity model,string id);
        void Delete(string id);

        void Insert(TEntity model);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> FilterBy(Expression<Func<TEntity, bool>> filter);
    }
}
