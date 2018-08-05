using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LYC.StdMgt.Ioc;
using LYC.StdMgt.Repository.Contract;
using LYC.StdMgt.BusinessService.Test.Mockups;
using Unity;
using LYC.StdMgt.BusinessService.Contracts;
using LYC.StdMgt.Domain;

namespace LYC.StdMgt.BusinessService.Test
{
    [TestClass]
    public class StudentManagerTest
    {
        IOCUnityContainers unityContainer = new IOCUnityContainers();
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void StudentAgeValidation()
        {
            var container = unityContainer.GetBusinessServiceTestUnityContainer();
            container.RegisterType<IStudentRepository, StudentRepositoryDummy>();

            IStudentManager studentManager = container.Resolve<IStudentManager>();

            Student testStudent = new Student()
            {
                FirstName = "TestName",
                DOB = DateTime.Today //.AddYears(-24)
            };

            bool result = studentManager.AddStudent(testStudent);

            Assert.IsFalse(result);

           // return true;
        }
    }
}
