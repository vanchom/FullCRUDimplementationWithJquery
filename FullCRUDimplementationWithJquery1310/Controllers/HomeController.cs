using FullCRUDimplementationWithJquery1310.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace FullCRUDimplementationWithJquery1310.Controllers
{
    public class HomeController : Controller
    {
        Nueva1310Entities db = new Nueva1310Entities();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStudentList()
        {
            List<StudentViewModel> StuList = db.tblStudents.Where(x => x.IsDelete == false).Select(x => new StudentViewModel
            {
                StudentId = x.StudentId,
                StudentName = x.StudentName,
                Email = x.Email,
                DepartmentName = x.tblDepartment.DepartmentName
            }).ToList();
            return Json(StuList, JsonRequestBehavior.AllowGet);
        }
    }
}