using LYC.StdMgt.BusinessService;
using LYC.StdMgt.BusinessService.Contracts;
using LYC.StdMgt.Repository;
using LYC.StdMgt.Repository.Contract;
using LYC.StdMgt.Utils.Log;
using LYC.StdMgt.Utils.Log.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace LYC.StdMgt.Ioc
{
    public class IOCUnityContainers
    {

        public UnityContainer GetLiveUnityContainer()
        {

            var container = new UnityContainer();
            container.RegisterType<IStudentManager, StudentManager>();
            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<ILogger, Logger>();

            return container;
        }

        public UnityContainer GetTestUnityContainer()
        {

            var container = new UnityContainer();
            container.RegisterType<IStudentManager, StudentManager>();
            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<ILogger, LoggerTest>();

            return container;
        }

        public UnityContainer GetBusinessServiceTestUnityContainer()
        {

            var container = new UnityContainer();
            container.RegisterType<IStudentManager, StudentManager>();
           // container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<ILogger, LoggerTest>();

            return container;
        }
    }
}
