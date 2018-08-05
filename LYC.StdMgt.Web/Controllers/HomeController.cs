using LYC.StdMgt.BusinessService.Contracts;
using LYC.StdMgt.Domain;
using LYC.StdMgt.Utils.Log.Contracts;
using LYC.StdMgt.Web.Models;
using System;
using System.Web.Mvc;
using AutoMapper;

namespace LYC.StdMgt.Web.Controllers
{
    public class HomeController : Controller
    {
        private IStudentManager _studentManager;
        private ILogger _logger;
        public HomeController(IStudentManager studentManager, ILogger logger)
        {
            _studentManager = studentManager;
            _logger = logger;
        }


        public ActionResult Index()
        {
            // IStudentManager studentManager = Ioc.Ioc.GetStudentManager(); //Initialize student mgr
            //_studentManager = Ioc.Ioc.GetStudentManager(); //Initialize student mgr

            Student student = new Student();

            student.Code = "S1";
            student.CreatedDateTime = DateTime.Now;
            student.FirstName = "Thilan";
            student.LastName = "Ma";
            student.Gender = Gender.Male;
            student.LastModifiedDateTime = DateTime.Now;
            student.DOB = Convert.ToDateTime("1989-09-28");
            student.ParentName = "ff";
            
            _studentManager.AddStudent(student);

          //  StudentViewModel studentViewModel = Mapper.Map<Student, StudentViewModel>(student);


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}