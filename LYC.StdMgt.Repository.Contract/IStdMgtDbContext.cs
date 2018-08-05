using LYC.StdMgt.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYC.StdMgt.Repository.Contract
{
    public interface IStdMgtDbContext : IDisposable
    {

        Database Database { get; }
        int SaveChanges();
        //Task<int> SaveChangesAsync();
        //Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbSet Set(Type entityType);
        DbEntityEntry Entry(object entity);
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        DbSet<Student> Student { get; set; }
        DbSet<Teacher> Teacher { get; set; }
        DbSet<Course> Course { get; set; }
        DbSet<Subject> Subject { get; set; }
        DbSet<Enrollment> Enrollment { get; set; }
        DbContext GetDatabaseContext { get; }
    }
}
