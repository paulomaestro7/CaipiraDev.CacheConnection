using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CaipiraDev.Repository.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        T GetOne(Expression<Func<T, bool>> expression);
        ICollection<T> Get(Expression<Func<T, bool>> expression);
        ICollection<T> GetAll();
        ObjectId InsertOne(T model);
    }
}
