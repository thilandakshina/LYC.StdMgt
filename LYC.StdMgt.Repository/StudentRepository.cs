using LYC.StdMgt.Domain;
using System;
using LYC.StdMgt.Repository.Contract;
using LYC.StdMgt.Utils.Log.Contracts;

namespace LYC.StdMgt.Repository
{
    // public class StudentRepository : Repository<Student>, IStudentRepository
    public class StudentRepository : Repository<Student>, IStudentRepository

    {

        public StudentRepository (ILogger logger) : base(logger)
        {

        }
        public bool CreateXXZ(Student obj)
        {
            throw new NotImplementedException();
        }

    }
}
