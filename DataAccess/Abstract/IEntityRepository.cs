using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    //generic constraint
    //class : referans tip
    //IEntity olabilir ya da IEntity implemente eden bir nesne olabilir
    //new(): new'lenebilir olmak zorunda
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter); 
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}
