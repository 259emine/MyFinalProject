using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint-kısıtlama diyoruz yani generic
    //class :referans tipli
    //IEntity:IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
   public interface IEntityRepository<T> where T:class,IEntity,new()     //ben buraya ne yazarsam tip o olur
    {

        List<T> GetAll(Expression<Func<T,bool>> filter=null); 
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
