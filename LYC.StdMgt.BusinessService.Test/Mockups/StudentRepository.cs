using LYC.StdMgt.Domain;
using System;
using LYC.StdMgt.Repository.Contract;
using LYC.StdMgt.Utils.Log.Contracts;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity;

namespace LYC.StdMgt.BusinessService.Test.Mockups
{
    // public class StudentRepository : Repository<Student>, IStudentRepository
    public class StudentRepositoryDummy :  IStudentRepository

    {
       
        public StudentRepositoryDummy(ILogger logger)
        {

        }
        public bool CreateXXZ(Student obj)
        {
            throw new NotImplementedException();
        }

        public bool Create(Student obj)
        {
            return true;
        }

        public bool Delete(Student obj)
        {
            throw new NotImplementedException();
        }

        public Student Find(Expression<Func<Student, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Student> FindList(Expression<Func<Student, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            return true;
        }

        public bool Update(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}
