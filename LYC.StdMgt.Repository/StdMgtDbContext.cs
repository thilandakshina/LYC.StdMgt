using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LYC.StdMgt.Repository.Contract;
using System.Data.Entity;
using LYC.StdMgt.Domain;

namespace LYC.StdMgt.Repository
{

   public class StdMgtDbContext : DbContext //, IStdMgtDbContext
    {
        public StdMgtDbContext() : base("StudentMgtConnectionString")
        {

        }

        DbSet<Student> Student { get; set; }
        DbSet<Teacher> Teacher { get; set; }
        DbSet<Course> Course { get; set; }
        DbSet<Subject> Subject { get; set; }
        DbSet<Enrollment> Enrollment { get; set; }
        DbContext GetDatabaseContext { get; set; }

        //DbSet<Student> IStdMgtDbContext.Student
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }

        //    set
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //DbContext IStdMgtDbContext.GetDatabaseContext
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }

        //    set
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }

}
