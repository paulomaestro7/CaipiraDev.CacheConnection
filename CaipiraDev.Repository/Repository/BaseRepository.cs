using CaipiraDev.Repository.Interface;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace CaipiraDev.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ILiteCollection<T> _iLiteCollection;
        public BaseRepository(ILiteDatabase ILiteDatabase)
        {
            _iLiteCollection = ILiteDatabase.GetCollection<T>();
        }
        public T GetOne(Expression<Func<T, bool>> expression)
        {
            return _iLiteCollection.FindOne(expression);
        }
        public ICollection<T> Get(Expression<Func<T, bool>> expression)
        {
            return _iLiteCollection.Find(expression).ToList();
        }
        public ICollection<T> GetAll()
        {
            return _iLiteCollection.FindAll().ToList();
        }
        public ObjectId InsertOne(T model)
        {
            return _iLiteCollection.Insert(model).AsObjectId;
        }
    }
}
