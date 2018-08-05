using LYC.StdMgt.BusinessService;
using LYC.StdMgt.BusinessService.Contracts;
using LYC.StdMgt.Repository;
using LYC.StdMgt.Repository.Contract;
using LYC.StdMgt.Utils.Log;
using LYC.StdMgt.Utils.Log.Contracts;

namespace LYC.StdMgt.Ioc
{
    public static class Ioc
    {
        public static IStudentManager GetStudentManager()
        {
            ILogger logger = new Logger();
            IStudentRepository studentRepository = new StudentRepository(logger);
            StudentManager studentManager = new StudentManager(studentRepository, logger);
           
            return studentManager;
        }
    }
}
