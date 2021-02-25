using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //class : referans tip olabilir anlamına gelir
    //Ientity :IEntity olabilir veya onu implemente eden classlar olabilir.
    //new() : newlenebilir yani obje üretilebilir olmalı (IEntity interfacesini devre dışı bırakmış olduk)


    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllByCategory(int categoryId);
    }
}
