using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data;
using System.Data.Entity;
using Help.Domain;

namespace Help.DataAccess
{
    public class GenericRepository<TEntity> :IRepository<TEntity> where TEntity : class
    {
        internal HelpDBContext context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(HelpDBContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }


        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == System.Data.Entity.EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = System.Data.Entity.EntityState.Modified;
        }
        
        
    }


    //class GenericRepository<T> : IRepository<T> where T : class
    //{
    //    private EAttendanceContext entities = null;
    //    IObjectSet<T> _objectSet;

    //    public GenericRepository(EAttendanceContext _entities)
    //    {
    //        entities = _entities;
    //        _objectSet = entities.CreateObjectSet<T>();
    //    }

    //    public IEnumerable<T> GetAll(Func<T, bool> predicate = null)
    //    {
    //        if (predicate != null)
    //        {
    //            return _objectSet.Where(predicate);
    //        }

    //        return _objectSet.AsEnumerable();
    //    }

    //    public T Get(Func<T, bool> predicate)
    //    {
    //        return _objectSet.First(predicate);
    //    }

    //    public void Add(T entity)
    //    {
    //        _objectSet.AddObject(entity);
    //    }

    //    public void Attach(T entity)
    //    {
    //        _objectSet.Attach(entity);
    //    }

    //    public void Delete(T entity)
    //    {
    //        _objectSet.DeleteObject(entity);
    //    }
    //}

}
