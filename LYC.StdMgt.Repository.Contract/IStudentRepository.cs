using LYC.StdMgt.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYC.StdMgt.Repository.Contract
{
    public interface IStudentRepository : IRepository<Student>
    {
        bool CreateXXZ(Student obj);
    }
}
