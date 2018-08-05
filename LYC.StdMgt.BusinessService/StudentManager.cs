using LYC.StdMgt.BusinessService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LYC.StdMgt.Domain;
using LYC.StdMgt.Repository.Contract;
using LYC.StdMgt.Utils.Log;
using LYC.StdMgt.Utils.Log.Contracts;

namespace LYC.StdMgt.BusinessService
{


    public class StudentManager : IStudentManager
    {
        private IStudentRepository _studentRepository;
        private ILogger _logger;
        public StudentManager(IStudentRepository studentRepository,ILogger logger)
        {
            _studentRepository = studentRepository;
            _logger = logger;
        }

        public bool AddStudent(Student s)
        {

            if (DateTime.Today.Subtract(s.DOB).Days >= (365 *18))
            {
                bool status = _studentRepository.Create(s);
                if (status == true)
                {
                    status = _studentRepository.Save();
                }
                return status;
            }
            else
            {
                return false;
            }

            
        }
    }
}
