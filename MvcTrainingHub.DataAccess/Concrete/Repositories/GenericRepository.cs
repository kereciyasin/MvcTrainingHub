using MvcTrainingHub.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MvcTrainingHub.DataAccess.Context;
using System.Data.Entity;
using MvcTrainingHub.Entities.Concrete;




namespace MvcTrainingHub.DataAccess.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        AppDbContext c = new AppDbContext();

        DbSet<T> _objectSet;

        public GenericRepository()
        {
            _objectSet = c.Set<T>();
        }

        public void Delete(T p)
        {
            _objectSet.Remove(p);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _objectSet.ToList();
        }

        public void Insert(T p)
        {
            _objectSet.Add(p);
            c.SaveChanges();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _objectSet.Where(filter).ToList();
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }

}
