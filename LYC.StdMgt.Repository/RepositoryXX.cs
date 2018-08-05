﻿using LYC.StdMgt.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LYC.StdMgt.Repository
{
    public abstract class RepositoryXX<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //  private readonly IDbContextCommon _context;*//// <summary>
        /// IStdMgtDbContext
        /// </summary>
        /// <param name="context"></param>
        /// 
        //private readonly StdMgtDbContext _context;

        private readonly IStdMgtDbContext  _context; 

        protected Repository(IStdMgtDbContext context)
        {
            _context = context;
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public virtual TEntity Get(long id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual async Task<TEntity> GetAsync(long id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        //public TEntity Find<TEntity>(Expression<Func<TEntity, bool>> predicate) 
        //{
        //    return _context.Set<TEntity>().FirstOrDefault(predicate);
        //}

        //public List<TEntity> FindList<TEntity>(Expression<Func<TEntity, bool>> predicate) 
        //{
        //    return _context.Set<TEntity>().Where<TEntity>(predicate).ToList();
        //}

        //public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> filter = null,
        //    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        //{
        //    IQueryable<TEntity> query = _context.Set<TEntity>();
        //    if (filter != null)
        //    {
        //        query = query.Where(filter);
        //    }

        //    query = includeProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
        //        .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        //    return orderBy != null ? orderBy(query).ToList() : query.ToList();
        //}

        public virtual TEntity Add(TEntity t)
        {
            _context.Set<TEntity>().Add(t);
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                //foreach (var eve in e.EntityValidationErrors)
                //{
                //    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                //        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                //    foreach (var ve in eve.ValidationErrors)
                //    {
                //        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                //            ve.PropertyName, ve.ErrorMessage);
                //    }
                //}
                //throw;
            }
            catch (DbUpdateException dbu)
            {
                //var exception = HandleDbUpdateException(dbu);
                //throw;
            }
            return t;
        }

        private Exception HandleDbUpdateException(DbUpdateException dbu)
        {
            var builder = new StringBuilder("A DbUpdateException was caught while saving changes. ");

            try
            {
                foreach (var result in dbu.Entries)
                {
                    builder.AppendFormat("Type: {0} was part of the problem. ", result.Entity.GetType().Name);
                }
            }
            catch (Exception e)
            {
                builder.Append("Error parsing DbUpdateException: " + e.ToString());
            }

            string message = builder.ToString();
            return new Exception(message, dbu);
        }

       

        public virtual void Delete(TEntity entityToDelete)
        {
            _context.Set<TEntity>().Remove(entityToDelete);
            _context.SaveChanges();
        }


        public virtual TEntity Update(TEntity modifiableObject)
        {
            DbEntityEntry<TEntity> entry = _context.Entry(modifiableObject);
            if (entry.State == EntityState.Detached)
            {
                _context.Set<TEntity>().Attach(modifiableObject);
                entry.State = EntityState.Modified;
            }
            _context.SaveChanges();
            return modifiableObject;
        }

       

        public void Dispose()
        {
            _context.Dispose();
        }

        //public virtual async Task<TEntity> AddAsync(TEntity t)
        //{
        //    _context.Set<TEntity>().Add(t);
        //    await _context.SaveChangesAsync();
        //    return t;
        //}

        //public virtual async Task<int> DeleteAsync(TEntity entityToDelete)
        //{
        //    _context.Set<TEntity>().Remove(entityToDelete);
        //    return await _context.SaveChangesAsync();
        //}

        //public virtual int Count()
        //{
        //    return _context.Set<TEntity>().Count();
        //}

        //public virtual async Task<int> CountAsync()
        //{
        //    return await _context.Set<TEntity>().CountAsync();
        //}

        //public virtual IEnumerable<TEntity> ExecuteSqlQueryResult(string query, int commandTimeOut,
        //    params object[] parameters)
        //{
        //    if (commandTimeOut > 0)
        //    {
        //        _context.Database.CommandTimeout = commandTimeOut;
        //    }

        //    return _context.Database.SqlQuery<TEntity>(query, parameters);
        //}

        //public virtual void ExecuteSqlQuery(string query, int commandTimeOut, params object[] parameters)
        //{
        //    if (commandTimeOut > 0)
        //    {
        //        _context.Database.CommandTimeout = commandTimeOut;
        //    }

        //    _context.Database.ExecuteSqlCommand(query, parameters);
        //}

        //public virtual async Task<int> ExecuteSqlQueryAsync(string query, int commandTimeOut, params object[] parameters)
        //{
        //    if (commandTimeOut > 0)
        //    {
        //        _context.Database.CommandTimeout = commandTimeOut;
        //    }

        //    return await _context.Database.ExecuteSqlCommandAsync(query, parameters);
        //}

        //public virtual async Task<TEntity> UpdateAsync(TEntity modifiableObject)
        //{
        //    DbEntityEntry<TEntity> entry = _context.Entry(modifiableObject);
        //    if (entry.State == EntityState.Detached)
        //    {
        //        _context.Set<TEntity>().Attach(modifiableObject);
        //        entry.State = EntityState.Modified;
        //    }
        //    await _context.SaveChangesAsync();
        //    return modifiableObject;
        //}

        //public virtual void BulkInserts(IEnumerable<TEntity> entities, BulkInsertOptions options)
        //{
        //    _context.BulkInsertExtention(entities, options);
        //}
    }
}
