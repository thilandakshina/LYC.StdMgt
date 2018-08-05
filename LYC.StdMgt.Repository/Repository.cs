using LYC.StdMgt.Repository.Contract;
using LYC.StdMgt.Utils.Log;
using LYC.StdMgt.Utils.Log.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LYC.StdMgt.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ILogger _logger;
        private readonly StdMgtDbContext _context;

        // [InjectionConstructor]
        public Repository(ILogger logger)   //ILogger _logger
        {
            _context = new StdMgtDbContext();

            _logger = logger;
        }
       // InsuranceDBContext _context = new InsuranceDBContext();
        public bool Create(T obj) 
        {
            _logger.LogError("Test Error Log******");
            try
            {
                _context.Set<T>().Add(obj);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool Delete(T obj) 
        {
            try
            {
                _context.Set<T>().Remove(obj);
                return true;
            }
            catch (Exception edb)
            {
                return false;
            }
        }

        public T Find(Expression<Func<T, bool>> predicate) 
        {
            return _context.Set<T>().FirstOrDefault<T>(predicate);
        }

        public List<T> FindList(Expression<Func<T, bool>> predicate) 
        {
            return _context.Set<T>().Where<T>(predicate).ToList();
        }

        public List<T> GetAll() 
        {
            return _context.Set<T>().ToList();
        }

        public bool Save()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception edb)
            {
                return false;
            }
        }

        //public bool Save(T obj)
        //{
        //    try
        //    {
        //        _context.Set<T>().Add(obj);
        //        _context.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception edb)
        //    {
        //        return false;
        //    }
        //}

        public bool Update(T obj) 
        {
            try
            {
                var edbstate = _context.Entry(obj);
                _context.Set<T>().Attach(obj);
                edbstate.State = EntityState.Modified;
                return true;
            }
            catch (Exception edb)
            {
                return false;
            }
        }
    }
}
