using LYC.StdMgt.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYC.StdMgt.BusinessService.Contracts
{
    public interface IStudentManager
    {
        bool AddStudent(Student s);
    }
}
